//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public delegate R Analyzer<S,R>(in S src);

    public static class SpanAnalyzer
    {
        [MethodImpl(Inline)]
        public static SpanAnalyzer<S,R> Create<S,R>(Analyzer<S,R> f)
            => new SpanAnalyzer<S,R>(f);
    }

    public readonly struct SpanAnalyzer<S,R>
    {
        readonly Analyzer<S,R> F;

        [MethodImpl(Inline)]
        internal SpanAnalyzer(Analyzer<S,R> f)
        {
            this.F = f;
        }

        [MethodImpl(Inline)]
        public Span<R> Analyze(ReadOnlySpan<S> src, Span<R> dst)
        {
            ref readonly var inputs = ref first(src);
            ref var outputs = ref first(dst);

            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var input = ref skip(inputs, i);
                seek(outputs,i) = F(input);                
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public Span<R> Analyze(ReadOnlySpan<S> src)
        {
            var dst = Spans.alloc<R>(src.Length);
            return Analyze(src,dst);
        }
    }
}