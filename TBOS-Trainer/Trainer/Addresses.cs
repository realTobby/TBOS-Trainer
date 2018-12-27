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

        public static long PLAYER_BASE_ADDRESS => GetPlayerBaseAddress();
        public static bool PlayerBaseAddressFound = false;
        private static long playerBaseAddress;

        public static long PLAYER_STAT_FIRERATE => PLAYER_BASE_ADDRESS + 144;
        public static long PLAYER_STAT_RANGE => PLAYER_BASE_ADDRESS + 164;
        public static long PLAYER_STAT_RANGEMULTIPLIER => PLAYER_BASE_ADDRESS + 148;
        public static long PLAYER_STAT_MOVEMENTSPEED => PLAYER_BASE_ADDRESS + 356;
        public static long PLAYER_STAT_LUCK => PLAYER_BASE_ADDRESS + 360;
        public static long PLAYER_STAT_DAMAGE => PLAYER_BASE_ADDRESS + 160;

        public static long PLAYER_STAT_TEAR_COLOR_INSIDE => PLAYER_BASE_ADDRESS + 184;
        public static long PLAYER_STAT_TEAR_COLOR_BORDER => PLAYER_BASE_ADDRESS + 188;

        private static long GetPlayerBaseAddress()
        {
            if (Context.Attached && PlayerBaseAddressFound)
            {
                return playerBaseAddress;
            }
            return RefreshPlayerAddress();
        }

        public static long RefreshPlayerAddress()
        {
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
