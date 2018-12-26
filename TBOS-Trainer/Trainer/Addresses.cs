using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBOS_Trainer.Trainer
{
    public static class Addresses
    {
        const string SEARCH_PATTERN = "?? ?? ?? ?? ?? 00 00 00 ?? 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 03 00 00 00 ?? ?? ?? ?? 00 00 00 00 ?? 00 00 00 ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF ?? 00 00 00";

        public static long PLAYER_BASE_ADDRESS => getPlayerBaseAddress();
        public static bool PlayerBaseAddressFound = false;
        private static long playerBaseAddress;

        private static long getPlayerBaseAddress()
        {
            if (Context.Attached && PlayerBaseAddressFound)
            {
                return playerBaseAddress;
            }

            var scan = Program.Memory.AoBScan("0", 0xffffffff, SEARCH_PATTERN);
            scan.Wait();

            if (scan.IsCompleted && scan.Result > 0)
            {
                PlayerBaseAddressFound = true;
            }

            long result = scan.Result - 36;
            playerBaseAddress = result;
            return result;
        }
    }
}
