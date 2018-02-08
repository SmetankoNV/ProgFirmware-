using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgFirmware.Source.Helpers;

namespace ProgFirmware.Source.CLI
{
    public class CliParser
    {
        #region Методы

        public static void Run(string[] args, List<CliOption> options)
        {
            foreach (var arg in args)
            {
                var text = "";
                var isShort = false;
                if (arg.StartsWith("--"))
                {
                    // Long name
                    text = arg.TrimStartEx("--");
                }
                else if (arg.StartsWith("-"))
                {
                    // Short name
                    text = arg.TrimStartEx("-");
                    isShort = true;
                }
                else
                {
                    continue;
                }

                var arr = text.SplitEx("=");
                string optName;
                var optValue = string.Empty;
                switch (arr.Length)
                {
                    case 1:
                        optName = arr[0];
                        break;
                    case 2:
                        optName = arr[0];
                        optValue = arr[1];
                        break;
                    default:
                        continue;
                }

                var opt = options.FirstOrDefault(x => isShort
                    ? x.ShortName.EqualsOrdinalEx(optName)
                    : x.LongName.EqualsOrdinalEx(optName));

                if (opt != null)
                {
                    opt.Value = optValue;
                }

            }
        }

        #endregion
    }
}
