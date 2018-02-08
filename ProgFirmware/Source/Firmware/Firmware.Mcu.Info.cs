using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgFirmware.Source.Devices;

namespace ProgFirmware.Source.Firmware
{
    public class FirmwareMcuInfo
    {
        #region Свойства

        /// <summary>
        /// Тип устройства
        /// </summary>
        public Device Device { get; }

        /// <summary>
        /// Тип устройства
        /// </summary>
        public int Serial { get; }

        /// <summary>
        /// Версия
        /// </summary>
        public Version Version { get; }

        /// <summary>
        /// Название приложения
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Время компиляции
        /// </summary>
        public DateTime BuildTime { get; }

        /// <summary>
        /// Данные
        /// </summary>
        public byte[] Data { get; set; }

        #endregion

        #region Конструктор

        public FirmwareMcuInfo(Device device, int serial, Version version, string name, DateTime buildTime)
        {
            Device = device;
            Serial = serial;
            Version = version;
            Name = name;
            BuildTime = buildTime;
            Data = null;
        }

        #endregion
    }
}
