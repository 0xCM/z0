//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;
    using static memory;

    public sealed class ToolShellRunner : WfService<ToolShellRunner,IToolShellRunner>, IToolShellRunner
    {
        public Index<CmdTypeInfo> Intrinsics()
            => Cmd.cmdtypes(Wf);

        string Format(int i, in CmdTypeInfo src)
            => string.Format("{0,-3} {1}", i, src.DataType.Name);

        void Render(ReadOnlySpan<CmdTypeInfo> src, ITextBuffer dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(src,i).Format());
        }

        public void ShowIntrinsics()
        {
            var types = Intrinsics();
            var buffer = text.buffer();
            Render(Intrinsics(), buffer);
            Wf.Row(buffer.Emit());
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

        public FS.FilePath ScriptFile<K>(K kind, Name name, ToolShellKind shell)
        {
            var x = shell switch{
                ToolShellKind.Cmd => FS.Extensions.Cmd,
                ToolShellKind.Ps => FS.Extensions.Ps1,
                _ => FS.FileExt.Empty
            };
            return Db.ScriptFile(kind,name,x);
        }

        public CmdLine CmdLine(FS.FilePath script, ToolShellKind shell)
        {
            return shell switch{
                ToolShellKind.Cmd => WinCmd.script(script),
                ToolShellKind.Ps => Pwsh.script(script),
                _ => Z0.CmdLine.Empty
            };
        }

        public Outcome<TextLines> RunScript<K>(K kind, Name name, ToolShellKind shell)
        {
            var file = ScriptFile(kind,name, shell);
            var command = CmdLine(file,shell);
            var result = Run(command);
            if(result)
                root.iter(result.Data, line => Wf.Row(line));
            return result;
        }

        public Outcome<TextLines> RunCmdScript<K>(K kind, Name name)
            => RunScript(kind,name, ToolShellKind.Cmd);

        public Outcome<TextLines> RunPsScript<K>(K kind, Name name)
            => RunScript(kind,name, ToolShellKind.Ps);
    }
}