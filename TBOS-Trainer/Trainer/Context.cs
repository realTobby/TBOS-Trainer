namespace TBOS_Trainer.Trainer
{
    public static class Context
    {
        const string GAME_NAME = "isaac-ng";

        public static bool Attached = false;

        private static int gameId;

        public static void Attach()
        {
            gameId = Program.Memory.getProcIDFromName(GAME_NAME);

            if (gameId > 0)
            {
                Attached = Program.Memory.OpenProcess(gameId);
            }
        }
    }
}
