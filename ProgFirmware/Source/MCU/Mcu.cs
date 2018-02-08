using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFirmware.Source.MCU
{
    public class Mcu
    {
        #region Свойства

        public McuType Typ { get; private set; }

        public int FlashSize { get; set; }

        public uint BootAddr { get; set; }

        public int BootSize { get; set; }

        public uint AppAddr { get; set; }

        public int AppSize { get; set; }

        #endregion

        #region Конструктор

        public Mcu(McuType typ)
        {
            Typ = typ;

            switch (typ)
            {
                case McuType.Stm32F446xe:
                case McuType.Stm32F103xe:
                    {
                        FlashSize = 512 * 1024;
                        BootAddr = 0x08000000;
                        BootSize = 16 * 1024;
                        AppAddr = BootAddr + 32 * 1024;
                        AppSize = 224 * 1024;
                    }
                    break;
                case McuType.Stm32F107xc:
                    {
                        FlashSize = 256 * 1024;
                        BootAddr = 0x08000000;
                        BootSize = 16 * 1024;
                        AppAddr = BootAddr + 32 * 1024;
                        AppSize = 112 * 1024;
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion
    }
}
