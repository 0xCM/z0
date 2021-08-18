//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        Outcome Run(string content, out ReadOnlySpan<TextLine> response)
            => CmdRunner.Run(WinCmd.cmd(content), ReceiveCmdStatus, ReceiveCmdError, out response);

        Outcome Run(CmdLine cmd, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(cmd, vars, ReceiveCmdStatus, ReceiveCmdError, out response);

        Outcome Run(ToolScript spec, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(spec, ReceiveCmdStatus, ReceiveCmdError, out response);

        Outcome Run(FS.FilePath src, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), vars, ReceiveCmdStatus, ReceiveCmdError, out response);

        Outcome Run(FS.FilePath src, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), CmdVars.Empty, ReceiveCmdStatus, ReceiveCmdError, out response);

        Outcome Run(FS.FilePath src, CmdVars vars)
        {
            var result = Outcome.Success;
            if(!src.Exists)
                return (false, FS.missing(src));
            result = Run(src, vars, out var response);
            if(result.Fail)
                return result;

            var flows = Tooling.flow(response);
            var count = flows.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var f = ref skip(flows,i);
                Write(string.Format("{0}:{1} -> {2}", f.Kind, f.Source, f.Target));
            }

            return result;
        }

        void ReceiveCmdStatus(in string src)
        {

        }

        void ReceiveCmdError(in string src)
        {
            Error(src);
        }
    }
}