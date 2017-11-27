﻿using Unosquare.Swan.Attributes;

namespace Unosquare.Labs.SshDeploy.Options
{
    public class MonitorVerbOptions : PushVerbOptions
    {
        [ArgumentOption('m', "monitor", DefaultValue = "sshdeploy.ready", HelpText = "The command to run on the target machine", Required = false)]       
        public string MonitorFile { get; set; }

        [ArgumentOption('l', "legacy", DefaultValue = false, HelpText = "Monitor files using legacy method", Required = false)]
        public bool Legacy { get; set; }
    }
}
