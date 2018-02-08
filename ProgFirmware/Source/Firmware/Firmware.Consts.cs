using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgFirmware.Source.Devices;
using ProgFirmware.Source.Helpers;
using ProgFirmware.Source.MCU;

namespace ProgFirmware.Source.Firmware
{
    public static class FirmwareConsts
    {
        #region Свойства

        public static List<Device> Devices { get; private set; }

        public static List<Mcu> Mcus { get; private set; }

        #endregion

        #region Конструктор

        static FirmwareConsts()
        {
            var stmf103xe = new Mcu(McuType.Stm32F103xe);
            var stmf107xc = new Mcu(McuType.Stm32F107xc);
            var stmf446xe = new Mcu(McuType.Stm32F446xe);

            var crutch00 = new Device(DeviceTyp.Crutch00, stmf103xe);
            var crutch01 = new Device(DeviceTyp.Crutch01, stmf446xe);
            var evnGoldbull = new Device(DeviceTyp.EvbGoldBull, stmf107xc);
            var evnGoldbullManul = new Device(DeviceTyp.EvbGoldBullManul, stmf107xc);
            var manul01 = new Device(DeviceTyp.Manul01, stmf446xe);
            var panthera01 = new Device(DeviceTyp.Panthera01, stmf446xe);

            Devices = new List<Device>
            {
                crutch00,
                crutch01,
                manul01,
                panthera01,
                evnGoldbull,
                evnGoldbullManul
            };

            Mcus = new List<Mcu>
            {
                stmf107xc,
                stmf103xe,
                stmf446xe
            };
        }

        #endregion
    }
}
