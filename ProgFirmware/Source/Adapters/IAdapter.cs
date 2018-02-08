using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFirmware.Source.Adapters
{
    internal interface IAdapter
    {
        #region Методы

        /// <summary>
        /// Проверка связи с адаптером
        /// </summary>
        bool Check();

        /// <summary>
        /// Очистка чипа
        /// </summary>
        void Erase();

        /// <summary>
        /// Блокировка чипа
        /// </summary>
        void Lock();

        /// <summary>
        /// Программирование чипа
        /// </summary>
        /// <param name="location">Путь к HEX-файлу (формат IntelHex)</param>
        void Program(string location);

        /// <summary>
        /// Программный рестарт
        /// </summary>
        void ResetSoft();

        /// <summary>
        /// Запись серийного номера
        /// </summary>
        void WriteSerial(uint serial);

        #endregion
    }
}
