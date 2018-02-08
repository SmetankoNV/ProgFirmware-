using System;
using System.IO;
using System.Linq;
using ProgFirmware.Source.Helpers;

namespace ProgFirmware.Source.Adapters
{
    public class StLinkAdapter : IAdapter
    {
        #region Поля

        /// <summary>
        ///     Расположение исполняемого CLI--файла
        /// </summary>
        private string _exeLocation;

        #endregion

        #region Конструктор

        public StLinkAdapter()
        {
            _exeLocation = SearchExe();
        }

        #endregion

        #region Перечисления

        private enum StLinkResult
        {
            ErrExe = -1,

            Ok = 0,

            ErrArgs = 1,

            ErrConnection = 2,

            CmdNotAvailable = 3,

            ErrWrite = 4,

            ErrRead = 5,

            ErrReset = 6,

            ErrRun = 7,

            ErrHalt = 8,

            ErrStep = 9,

            ErrSetClearBp = 10,

            ErrErase = 11,

            ErrProgram = 12,

            ErrProgramOptBytes = 13
        }

        #endregion

        #region Константы

        /// <summary>
        ///     Название исполняемого файла
        /// </summary>
        private const string EXE_NAME = @"ST-LINK_CLI.exe";

        /// <summary>
        ///     Директория установки версий Segger ПО
        /// </summary>
        private const string ROOT_LOCATION = @"c:\Program Files (x86)\STMicroelectronics\";

        #endregion

        #region Методы

        public bool Check()
        {
            // Поиск расположения исполняемого файла
            _exeLocation = SearchExe();

            if (_exeLocation.IsNotValid())
                throw new FileNotFoundException("Не найден файл " + EXE_NAME);

            // Проверка подключенного адаптера
            ListDevices();
            // Проверка подключенного устройства
            CheckConn();

            return false;
        }

        /// <summary>
        /// Поиск исполняемого файла
        /// </summary>
        private string SearchExe()
        {
            // Поиск расположения исполняемого файла
            try
            {
                var files = Files.GetFiles(ROOT_LOCATION, true, false, EXE_NAME);
                return files.FirstOrDefault();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        ///     Запуск утилиты CLI с аргументами
        /// </summary>
        private void RunCmd(string args)
        {
            var result = Processes.RunCli(_exeLocation, args, s => { }, s => { });

            if (result != 0)
                throw new Exception(((StLinkResult)result).ToString());
        }

        /// <summary>
        ///     Чтение списка подключенных устройств
        /// </summary>
        private void ListDevices()
        {
            RunCmd("-List");
        }

        /// <summary>
        ///     Подключение к устройству
        /// </summary>
        private void CheckConn()
        {
            RunCmd("-c SWD");
        }

        /// <summary>
        ///     Очистка чипа
        /// </summary>
        public void Erase()
        {
            RunCmd("-ME");
        }


        /// <summary>
        ///     Блокировка чипа
        /// </summary>
        public void Lock()
        {
            RunCmd("-OB RDP=1");
        }

        /// <summary>
        ///     Программирование чипа
        /// </summary>
        public void Program(string location)
        {
            RunCmd($"-P \"{location}\" -V -Q");
        }

        /// <summary>
        ///     Программынй рестарт
        /// </summary>
        public void ResetSoft()
        {
            RunCmd("-Rst");
        }

        /// <summary>
        ///     Запись серийного номера
        /// </summary>
        public void WriteSerial(uint serial)
        {
            var serialText = serial.ToStringEx(16);
            RunCmd($"-w32 0x08000200 0x{serialText}");
        }

        public override string ToString()
        {
            return "ST-Link/V2";
        }

        #endregion
    }
}