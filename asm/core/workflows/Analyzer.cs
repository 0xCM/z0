//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Analysis<R> : IAnalysis<R>
    {
        public R Result {get;}
    }

    public readonly struct Analyzer<S,R> : IAnalyzer<Analyzer<S,R>,S,R>
        where R : IAnalysis
    {
        readonly Func<S,R> F;

        [MethodImpl(Inline)]
        internal Analyzer(Func<S,R> f)
        {
            this.F = f;
        }

        [MethodImpl(Inline)]
        public R Analyze(in S src)
            => F(src);
    }
}