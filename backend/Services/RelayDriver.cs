using Microsoft.Extensions.Logging;
using System;

namespace backend.Services
{
    public interface RelayDriver : IRelayDriver
    {
        private IScriptService _scriptService;

        public RelayDriver(ILogger<RelayDriver> logger)
        {
            _logger = logger;
            _scriptService = new ScriptService();
        }

        bool Write(int chnl, bool val) {
            var cmd = $"./Scripts/iicDriver2.sh {chnl.toString()} {val.toString()}";
            _scriptService.Bash(cmd);
        }
    }
}
