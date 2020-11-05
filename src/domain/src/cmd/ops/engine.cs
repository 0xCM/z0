//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [Op]
        public static CmdEngine engine(IWfShell wf, CmdEngineMessage onMsg, CmdEngineError onError)
        {
            var settings = new CmdEngineSettings();
            settings.EngineKind = CmdEngineKind.CmdExe;
            settings.Path = FS.path("cmd.exe");

            var info = new ProcessStartInfo(settings.Path.Name);
            info.UseShellExecute = false;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.Arguments = EmptyString;
            return new CmdEngine(wf, settings, info, onMsg, onError);
        }
    }
}