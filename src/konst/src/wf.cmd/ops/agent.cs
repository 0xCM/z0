//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Part;

    partial struct Cmd
    {
        [Op]
        public static CmdAgent agent(IWfShell wf, ICmdObserver observer)
        {
            var settings = new CmdAgentSettings();
            settings.AgentKind = CmdAgentKind.CmdExe;
            settings.Path = FS.path("cmd.exe");

            var info = new ProcessStartInfo(settings.Path.Name);
            info.UseShellExecute = false;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.Arguments = EmptyString;
            return new CmdAgent(wf, settings, info, observer);
        }
    }
}