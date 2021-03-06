﻿namespace T
{
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args) => MainAsync(args).GetAwaiter().GetResult();

        static async Task MainAsync(string[] args)
        {
            var logger = Diagnostics.EventLogger.GetLogger();
            var config = Configuration.Config.Load(Strings.ConfigFileName);
            if (config == null)
            {
                logger.Error($"Failed to load config file '{Strings.ConfigFileName}'.");
                return;
            }

            var bot = new Bot(config);
            await bot.Start();

            System.Diagnostics.Process.GetCurrentProcess().WaitForExit();
            //while (true) { } macOS
        }
    }
}