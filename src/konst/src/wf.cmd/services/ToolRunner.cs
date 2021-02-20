//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;
    using static memory;

    public sealed class ToolRunner : WfService<ToolRunner,IToolRunner>, IToolRunner
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

        public Outcome<TextLines> RunCmdScript<K>(K kind, Name name)
        {
            var file = Db.ScriptFile(kind, name);
            var script = WinCmd.script(file);
            using var runner = ToolRunner.create(Wf);
            var result = runner.Run(script);
            if(result)
                root.iter(result.Data, line => Wf.Row(line));
            return result;
        }

        public Outcome<TextLines> RunPsScript<K>(K kind, Name name)
        {
            var file = Db.ScriptFile(kind, name, FS.Extensions.Ps1);
            var script = Pwsh.script(file);
            using var runner = ToolRunner.create(Wf);
            var result = runner.Run(script);
            if(result)
                root.iter(result.Data, line => Wf.Row(line));
            return result;
        }

    }
}