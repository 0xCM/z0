//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;
    using static memory;

    public sealed class ToolScriptRunner : WfService<ToolScriptRunner,IToolScriptRunner>, IToolScriptRunner
    {
        void Render(ReadOnlySpan<CmdTypeInfo> src, ITextBuffer dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(src,i).Format());
        }

        public Outcome<TextLines> Run(CmdLine cmd)
        {
            var flow = Wf.Running(cmd);
            try
            {
                var process = Cmd.process(Wf, cmd).Wait();
                var output = process.Output;
                var lines = Parse.lines(output);
                Wf.Ran(flow, lines.Count);
                return lines;
            }
            catch(Exception e)
            {
                Wf.Error(e);
                Wf.Ran(flow);
                return e;
            }
        }

        public FS.FilePath ScriptFile(ToolId tool, Name script, ToolScriptKind shell)
        {
            var x = shell switch{
                ToolScriptKind.Cmd => FS.Extensions.Cmd,
                ToolScriptKind.Ps => FS.Extensions.Ps1,
                _ => FS.FileExt.Empty
            };
            return Db.ToolScriptFile(tool, script, x);
        }

        public FS.FilePath ScriptFile<K>(K kind, Name script, ToolScriptKind shell)
        {
            var x = shell switch{
                ToolScriptKind.Cmd => FS.Extensions.Cmd,
                ToolScriptKind.Ps => FS.Extensions.Ps1,
                _ => FS.FileExt.Empty
            };
            return Db.ToolScriptFile(kind, script, x);
        }

        public CmdLine CmdLine(FS.FilePath script, ToolScriptKind shell)
        {
            return shell switch{
                ToolScriptKind.Cmd => WinCmd.script(script),
                ToolScriptKind.Ps => Pwsh.script(script),
                _ => Z0.CmdLine.Empty
            };
        }

        public Outcome<TextLines> RunScript(ToolId tool, Name name, ToolScriptKind shell)
        {
            var file = ScriptFile(tool,name, shell);
            var command = CmdLine(file,shell);
            var result = Run(command);
            if(result)
                root.iter(result.Data, line => Wf.Row(line));
            return result;
        }

        public Outcome<TextLines> RunScript<K>(K kind, Name name, ToolScriptKind shell)
        {
            var file = ScriptFile(kind,name, shell);
            var command = CmdLine(file,shell);
            var result = Run(command);
            if(result)
                root.iter(result.Data, line => Wf.Row(line));
            return result;
        }

        public Outcome<TextLines> RunCmdScript<K>(K kind, Name name)
            => RunScript(kind, name, ToolScriptKind.Cmd);

        public Outcome<TextLines> RunPsScript<K>(K kind, Name name)
            => RunScript(kind, name, ToolScriptKind.Ps);
    }
}