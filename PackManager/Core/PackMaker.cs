using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManager.Core
{
    public enum Action
    {
        Pack,
        Unpack,
    }

    public class PackMakerSettings
    {
        public string File { get; set; }
        public Action Action { get; set; }
        public bool ParallelProcessing { get; set;  } = true;
        public bool NoLog { get; set;  } = false;
    }

    internal class StartupGenerator
    {
        private readonly PackMakerSettings _settings;
        public StartupGenerator(PackMakerSettings settings)
        {
            _settings = settings;
        }

        public string Build()
        {
            var startup = BuildAction();
            if (_settings.ParallelProcessing)
                startup = $"{startup} --parallel";

            if (_settings.NoLog)
                startup = $"{startup} --nolog";

            return startup;
        }

        private string BuildAction()
        {
            var argument = _settings.Action == Action.Unpack ? "--pack" : "--unpack";
            
            return $"{argument} {_settings.File}";
        }
    }

    public static class PackMaker
    {
        private const string Binary = "PackMakerLite.exe";
        public static void Pack(PackMakerSettings settings)
        {
            settings.Action = Action.Pack;
            _ = CreatePackMakerProcess(settings).Start();
        }

        public static void Unpack(PackMakerSettings settings)
        {
            settings.Action = Action.Unpack;
            _ = CreatePackMakerProcess(settings).Start();
        }

        private static Process CreatePackMakerProcess(PackMakerSettings settings)
        {
            var clientProcess = new Process();
            clientProcess.StartInfo = new ProcessStartInfo
            {
                FileName = Binary,
                WorkingDirectory = Properties.Settings.Default.PackDirectory,
                Arguments = new StartupGenerator(settings).Build()
            };

            return clientProcess;
        }
    }
}
