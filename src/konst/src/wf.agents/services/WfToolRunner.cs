//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static TextRules;
    using static memory;

    public sealed class WfToolRunner : WfService<WfToolRunner,IWfToolRunner>, IWfToolRunner
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
    }
}