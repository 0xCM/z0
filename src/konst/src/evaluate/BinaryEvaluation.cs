//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BinaryEvaluation<T>
    {
        public readonly Pair<T> Source;

        public readonly PairEvalOutcome<T> Target;

        [MethodImpl(Inline)]
        public BinaryEvaluation(Pair<T> src, PairEvalOutcome<T> dst)
        {
            Source = src;
            Target = dst;
        }
    }
}