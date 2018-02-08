using ProgFirmware.Source.Helpers;
using ProgFirmware.Source.MCU;

namespace ProgFirmware.Source.Devices
{
    public class Device
    {
        #region Свойства

        /// <summary>
        /// Тип устройства
        /// </summary>
        public DeviceTyp Typ { get; }

        /// <summary>
        /// Тип процессора
        /// </summary>
        public Mcu Mcu { get; }

        #endregion

        #region Конструктор

        public Device(DeviceTyp typ)
        {
            Typ = typ;
        }

        public Device(DeviceTyp typ, Mcu mcu) : this(typ)
        {
            Mcu = mcu;
        }

        #endregion

        #region Методы

        public override string ToString()
        {
            return $"{Typ} ({Mcu.Typ})";
        }

        #endregion
    }
}