//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class Analyzer
    {
        [MethodImpl(Inline)]
        public static Analyzer<S,R> From<S,R>(Func<S,R> f)
            where R : IAnalysis
                => new Analyzer<S,R>(f);
    }

}