//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = UnmanagedParsers;

    using C = AsciCharCode;

    [ApiHost(ApiNames.UnmanagedParserCases, true)]
    public struct UnmanagedParserCases
    {
        [Op]
        public static UnmanagedParserCases create(IWfShell wf)
            => new UnmanagedParserCases(wf);

        readonly WfHost Host;

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        UnmanagedParserCases(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(UnmanagedParserCases));
            Wf = wf.WithHost(Host).WithVerbosity(LogLevel.Babble);
        }

        void Ran<C,T>(C @case, T data)
        {
            Wf.Ran2(delimit(@case, data));
        }

        [Op]
        public void Run()
        {
            Wf.Running();
            Ran(n0, test(n0).Format());
            Ran(n1, test(n1).Format());
            Ran(n2, test(n2).Format());
            Wf.Ran();
        }

        [Op]
        public BufferSegments<char> test(N0 n)
        {
            const string Input = "323,3333,33,1";
            const char Delimiter = ',';
            const byte SegCount = 4;

            api.create(Delimiter, out DelimitedSplitter<char> parser);
            var input = edit(span(Input));
            api.run(parser, input, out var segments);
            return segments;
        }

        [Op]
        public BufferSegments<ushort> test(N1 n)
        {
            const string Input = "90.33.33.391.385.9";
            const char Delimiter = '.';
            const byte SegCount = 6;

            api.create(Delimiter, out DelimitedSplitter<ushort> parser);
            var input = Spans.s16u(edit(span(Input)));
            api.run(parser, input, out var segments);
            return segments;
        }

        static ReadOnlySpan<AsciCharCode> Case2Input => new AsciCharCode[]{C.d9,C.d0,C.Dot, C.d3,C.d3,C.Dot, C.d3,C.d9,C.d1,C.Dot, C.d3,C.d8,C.d5,C.Dot, C.d9};

        [Op]
        public BufferSegments<AsciCharCode> test(N2 n)
        {
            const char Delimiter = '.';
            const byte SegCount = 6;

            api.create(AsciCharCode.Dot, out DelimitedSplitter<AsciCharCode> parser);
            var input = edit(Case2Input);
            api.run(parser, input, out var segments);
            return segments;
        }
    }
}