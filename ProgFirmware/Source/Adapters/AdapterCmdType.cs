using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFirmware.Source.Adapters
{
    internal enum AdapterCmdType
    {
        Check = 1,

        Erase = 2,

        Lock = 3,

        Program = 4,

        ResetSoft = 5,

        WriteSerial = 6,
    }
}
