using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgFirmware.Source.Helpers;

namespace ProgFirmware.Source.Firmware
{
    public class FirmwareMcu
    {
        /// <summary>
        /// Адрес расположения региона SERIAL для BOOT
        /// </summary>
        private const int ADDR_BOOT = 0x08000200;

        /// <summary>
        /// Адрес расположения региона SERIAL для APP
        /// </summary>
        private const int ADDR_APP = 0x08008200;

        /// <summary>
        /// Расположение заводского номера
        /// </summary>
        private const int OFFSET_SERIAL = 0;

        /// <summary>
        /// Расположение типа устройства
        /// </summary>
        private const int OFFSET_DEV_TYP = 4;

        /// <summary>
        /// Расположение названия приложения
        /// </summary>
        private const int OFFSET_NAME = 6;

        /// <summary>
        /// Расположение версии
        /// </summary>
        private const int OFFSET_VERSION = 30;

        /// <summary>
        /// Расположение времени компиляции
        /// </summary>
        private const int OFFSET_BUILD_TIME = 46;

        /// <summary>
        /// Расположение даты компиляции
        /// </summary>
        private const int OFFSET_BUILD_DATE = 62;

        /// <summary>
        /// Размер текста под именя приложения (байты)
        /// </summary>
        private const int NAME_SIZE = 24;

        /// <summary>
        /// Размер текста под версию (байты)
        /// </summary>
        private const int VERSION_SIZE = 16;

        /// <summary>
        /// Размер текста под время сборки (байты)
        /// </summary>
        private const int BUILD_TIME_SIZE = 16;

        /// <summary>
        /// Размер текста под дату сборки (байты)
        /// </summary>
        private const int BUILD_DATE_SIZE = 16;

        #region Свойства

        /// <summary>
        /// Hex-представление содержимого прошивки
        /// </summary>
        private IntelHex _hex;

        /// <summary>
        /// Расположение файла HEX или EXOBIN
        /// </summary>
        public string Location { get; }

        /// <summary>
        /// Данные о bootloader
        /// </summary>
        public FirmwareMcuInfo Boot { get; private set; }

        /// <summary>
        /// Данные о приложении
        /// </summary>
        public FirmwareMcuInfo App { get; private set; }

        #endregion

        #region Конструктор

        public FirmwareMcu(string location)
        {
            Location = location;
            Boot = null;
            App = null;
        }

        #endregion

        #region Методы

        public void LoadFromHex()
        {
            // Чтение текста из файла
            _hex = new IntelHex();
            _hex.LoadFile(Location);

            // Чтение типа устройства
            Boot = LoadInfo(ADDR_BOOT);
            App = LoadInfo(ADDR_APP);

            Boot.Data = _hex.ReadBufferFill(Boot.Device.Mcu.BootAddr, Boot.Device.Mcu.BootSize, 0xFF);
            App.Data = _hex.ReadBufferFill(App.Device.Mcu.AppAddr, App.Device.Mcu.AppSize, 0xFF);
        }

        /// <summary>
        /// Загрузка данных из региона
        /// </summary>
        private FirmwareMcuInfo LoadInfo(uint addr)
        {
            var typ = (DeviceTyp)_hex.ReadByte8(addr + OFFSET_DEV_TYP);

            var device = FirmwareConsts.Devices.FirstOrDefault(x => x.Typ == typ);
            if (device == null)
            {
                throw new Exception($"Not found device: {typ}");
            }

            var serial = _hex.ReadByte32(addr + OFFSET_SERIAL, Endianess.Little);
            var name = _hex.ReadBuffer(addr + OFFSET_NAME, NAME_SIZE).ToStringEx();
            var versionText = _hex.ReadBuffer(addr + OFFSET_VERSION, VERSION_SIZE).ToStringEx();
            var textTime = _hex.ReadBuffer(addr + OFFSET_BUILD_TIME, BUILD_TIME_SIZE).ToStringEx();
            var textDate = _hex.ReadBuffer(addr + OFFSET_BUILD_DATE, BUILD_DATE_SIZE).ToStringEx();

            var version = new Version(versionText);
            var buildTime = DateTime.Parse(textDate + " " + textTime);

            var info = new FirmwareMcuInfo(device, (int)serial, version, name, buildTime);

            return info;
        }

        /// <summary>
        /// Загрузка из файла
        /// </summary>
        public static FirmwareMcu LoadFromHexFile(string location)
        {
            // Чтение текста из файла
            var firmware = new FirmwareMcu(location);
            firmware.LoadFromHex();

            return firmware;
        }

        #endregion
    }
}
