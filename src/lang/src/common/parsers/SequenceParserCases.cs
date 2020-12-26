//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using C = AsciCharCode;

    [ApiHost(ApiNames.SyntaxParserCases, true)]
    public struct SequenceParserCases
    {
        [Op]
        public static SequenceParserCases create(IWfShell wf)
            => new SequenceParserCases(wf);

        readonly WfHost Host;

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        internal SequenceParserCases(IWfShell wf)
        {
            Host = WfShell.host(typeof(SequenceParserCases));
            Wf = wf.WithHost(Host).WithVerbosity(LogLevel.Babble);
        }

        void Ran<C,T>(WfExecFlow flow, C @case, T data)
        {
            Wf.Ran(flow, Seq.delimit(@case, data));
        }

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
        public BufferSegments<char> test(N0 n)
        {
            const string Input = "323,3333,33,1";
            const char Delimiter = ',';
            const byte SegCount = 4;

            var parser = SeqSplitter.create(Delimiter);
            var input = edit(span(Input));
            SeqSplitter.run(parser, input, out var segments);
            return segments;
        }

        [Op]
        public BufferSegments<ushort> test(N1 n)
        {
            const string Input = "90.33.33.391.385.9";
            const char Delimiter = '.';
            const byte SegCount = 6;

            var parser = SeqSplitter.create<ushort>(Delimiter);
            var input = Spans.s16u(edit(span(Input)));
            SeqSplitter.run(parser, input, out var segments);
            return segments;
        }

        static ReadOnlySpan<AsciCharCode> Case2Input
            => new AsciCharCode[]{C.d9,C.d0,C.Dot, C.d3,C.d3,C.Dot, C.d3,C.d9,C.d1,C.Dot, C.d3,C.d8,C.d5,C.Dot, C.d9};

        [Op]
        public BufferSegments<AsciCharCode> test(N2 n)
        {
            const char Delimiter = '.';
            const byte SegCount = 6;

            var parser = SeqSplitter.create(AsciCharCode.Dot);
            var input = edit(Case2Input);
            SeqSplitter.run(parser, input, out var segments);
            return segments;
        }
    }
}