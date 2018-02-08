using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFirmware.Source.Helpers
{
    public enum DeviceTyp
    {
        /// <summary>
        /// Неопределен
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Отладочная плата "Goldbull"
        /// </summary>
        EvbGoldBull = 10,

        /// <summary>
        /// Отладочная плата "STM Discovery F3"
        /// </summary>
        EvbStm32F3Discovery = 11,

        /// <summary>
        /// Отладочная плата "CC2650-DK"
        /// </summary>
        EvbCc2560Dk = 12,

        /// <summary>
        /// Временный модуль на базе Manul для реализации транзита WiFi 
        /// </summary>
        WiFiTransit = 13,

        /// <summary>
        /// Manul на плате Goldbull
        /// </summary>
        EvbGoldBullManul = 14,

        /// <summary>
        /// Panthera на плате Goldbull
        /// </summary>
        EvbGoldBullPanthera = 15,

        /// <summary>
        /// CrutchDisplay на плате Goldbull
        /// </summary>
        EvbGoldBullDisplay = 16,

        /// <summary>
        /// Manul-01 (с CAN)
        /// </summary>
        Manul01 = 51,

        /// <summary>
        /// Panthera (на CAN)
        /// </summary>
        Panthera01 = 52,

        /// <summary>
        /// Crutch (версия с внешним Bluetooth)
        /// </summary>
        Crutch00 = 53,

        /// <summary>
        /// Crutch (версия с дисплеем USMP-P27801
        /// </summary>
        Crutch01 = 54,

        /// <summary>
        /// Экзоскелет Альберт
        /// </summary>
        Albert = 100,

        /// <summary>
        /// Экзоскелет Оскар
        /// </summary>
        Oscar = 101,

        /// <summary>
        /// Общий тип "Экзоскелет"
        /// </summary>
        Skeleton = 102,

        /// <summary>
        /// Приложение "АРМ врача" для планшета Andoroid
        /// </summary>
        Albatross01 = 120,
    }

}
