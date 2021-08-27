//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public class OmniScript : AppService<OmniScript>
    {
        ScriptRunner ScriptRunner;

        CmdLineRunner CmdRunner;

        protected override void Initialized()
        {
            ScriptRunner = Wf.ScriptRunner();
            CmdRunner = Wf.CmdLineRunner();
        }

        public Outcome RunToolScript(FS.FilePath src, CmdVars vars, bool quiet, out ReadOnlySpan<ToolFlow> flows)
        {
            flows = default;

            var result = Outcome.Success;
            if(!src.Exists)
                return (false, FS.missing(src));
            result = Run(src, vars, quiet, out var response);
            if(result.Fail)
                return result;

            flows = Tooling.flow(response);
            var count = flows.Length;
            for(var i=0; i<count; i++)
                Write(skip(flows,i));

            return result;
        }

        public ReadOnlySpan<CmdResponse> ParseResponse(ReadOnlySpan<TextLine> src)
        {
            var count = src.Length;
            if(count == 0)
                Warn("No response to parse");

            var dst = list<CmdResponse>();

            for(var i=0; i<count; i++)
            {
                if(CmdResponse.parse(skip(src,i).Content, out var response))
                    dst.Add(response);
            }
            return dst.ViewDeposited();
        }

        public Outcome Run(string content, out ReadOnlySpan<TextLine> response)
            => CmdRunner.Run(WinCmd.cmd(content), ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        public Outcome Run(CmdLine cmd, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(cmd, vars, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        public Outcome Run(ToolScript spec, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(spec, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        public Outcome Run(FS.FilePath src, CmdVars vars, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), vars, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);

        public Outcome Run(FS.FilePath src, CmdVars vars, bool quiet, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), vars,
                quiet ? ReceiveCmdStatusQuiet : ReceiveCmdStatus, ReceiveCmdError,
                    out response);

        public Outcome Run(FS.FilePath src, out ReadOnlySpan<TextLine> response)
            => ScriptRunner.RunCmd(Cmd.cmdline(src.Format(PathSeparator.BS)), CmdVars.Empty, ReceiveCmdStatusQuiet, ReceiveCmdError, out response);


        public Outcome RunAsmScript(string srcid, ScriptId sid)
            => RunAsmScript(srcid,sid, out _);

        public Outcome RunProjectScript(ProjectId project, string srcid, Scope scope, ScriptId sid)
            => RunProjectScript(project, srcid, scope, sid, out _);

        public Outcome RunProjectScript(ProjectId project, string srcid, Scope scope, ScriptId sid, out ReadOnlySpan<ToolFlow> flows)
        {
            var path = Ws.Projects().Script(project, scope, sid, FS.Cmd);
            var result = Outcome.Success;
            var vars = WsVars.create();
            vars.SrcId = srcid;
            return RunToolScript(path, vars.ToCmdVars(), true, out flows);
        }

        public Outcome RunAsmScript(string srcid, ScriptId sid, out ReadOnlySpan<ToolFlow> flows)
        {
            var result = Outcome.Success;
            var vars = WsVars.create();
            var path = Ws.Asm().Script(sid);
            vars.SrcId = srcid;
            return RunToolScript(path, vars.ToCmdVars(), true, out flows);
        }

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