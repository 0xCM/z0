//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class AsmCmdService
    {
        Outcome Run(string content, out ReadOnlySpan<TextLine> response)
            => CmdRunner.Run(WinCmd.cmd(content), ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        Outcome Run(CmdLine cmd, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(cmd, vars, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        Outcome Run(ToolScript spec, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(spec, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        Outcome Run(FS.FilePath src, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), vars, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        Outcome Run(FS.FilePath src, CmdVars vars, bool quiet, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), vars,
                quiet ? ReceiveCmdStatusQuiet : ReceiveCmdStatus, ReceiveCmdError,
                    out response);

        Outcome Run(FS.FilePath src, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), CmdVars.Empty, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        void ReceiveCmdStatusQuiet(in string src)
        {

        }

        void ReceiveCmdStatus(in string src)
        {
            Write(src);
        }

        void ReceiveCmdError(in string src)
        {
            Error(src);
        }
    }
}