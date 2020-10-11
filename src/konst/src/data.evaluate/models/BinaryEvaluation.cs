//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BinaryEvaluation<A,B,R>
    {
        public readonly Paired<A,B> Source;

        public readonly PairEvalResult<R> Target;

        [MethodImpl(Inline)]
        public BinaryEvaluation(Paired<A,B> src, PairEvalResult<R> dst)
        {
            Source = src;
            Target = dst;
        }
    }
}