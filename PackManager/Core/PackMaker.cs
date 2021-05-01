using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManager.Core
{
    enum Action
    {
        Pack,
        Unpack,
    }
    
    class PackMakerSettings
    {
        public string File { get; set; }
        public Action Action { get; set; }
        public bool ParallelProcessing { get; set;  } = true;
        
        public bool NoLog { get; set;  } = false;
    }

    class StartupGenerator
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

    class PackMaker
    {
        private const string Binary = "PackMakerLite.exe";
        public static void Pack(string archive, PackMakerSettings settings)
        {
            settings.File = archive;
            
            var arguments = new StartupGenerator(settings).Build();
            var clientProcess = new Process();
            clientProcess.StartInfo = new ProcessStartInfo(Binary, arguments);
            clientProcess.Start();
        }

        public static void Unpack(string archive, PackMakerSettings settings)
        {
            settings.File = archive;
            
            var arguments = new StartupGenerator(settings).Build();
            var clientProcess = new Process();
            clientProcess.StartInfo = new ProcessStartInfo(Binary, arguments);
            clientProcess.Start();
        }
    }
}
