//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using C = AsciCharCode;

    [ApiHost]
    public struct SeqParserChecks
    {
        [Op]
        public static SeqParserChecks create(IWfShell wf)
            => new SeqParserChecks(wf);
        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        internal SeqParserChecks(IWfShell wf)
        {
            Wf = wf;
        }

        WfExecToken Ran<C,T>(WfExecFlow<string> flow, C @case, T data)
            => Wf.Ran(flow, Seq.delimit(Chars.Colon, 0, @case, data));

        [Op]
        public void Run()
        {
            var flow = Wf.Running();
            Ran(flow, n0, test(n0).Format());
            Ran(flow, n1, test(n1).Format());
            Ran(flow, n2, test(n2).Format());
            Wf.Ran(flow);
        }

        [Op]
        BufferSegments<char> test(N0 n)
        {
            const string Input = "323,3333,33,1";
            const char Delimiter = ',';
            const byte SegCount = 4;

            var parser = Seq.splitter(Delimiter);
            var input = edit(span(Input));
            Seq.split(parser, input, out var segments);
            return segments;
        }

        [Op]
        BufferSegments<ushort> test(N1 n)
        {
            const string Input = "90.33.33.391.385.9";
            const char Delimiter = '.';
            const byte SegCount = 6;

            var parser = Seq.splitter<ushort>(Delimiter);
            var input = memory.uint16(edit(span(Input)));
            Seq.split(parser, input, out var segments);
            return segments;
        }

        [Op]
        BufferSegments<AsciCharCode> test(N2 n)
        {
            const char Delimiter = '.';
            const byte SegCount = 6;

            var parser = Seq.splitter(AsciCharCode.Dot);
            var input = edit(Case2Input);
            Seq.split(parser, input, out var segments);
            return segments;
        }

        static ReadOnlySpan<AsciCharCode> Case2Input
            => new AsciCharCode[]{C.d9,C.d0,C.Dot, C.d3,C.d3,C.Dot, C.d3,C.d9,C.d1,C.Dot, C.d3,C.d8,C.d5,C.Dot, C.d9};
    }
}