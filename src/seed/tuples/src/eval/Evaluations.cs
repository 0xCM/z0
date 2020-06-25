//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class Evaluations
    {
        [MethodImpl(Inline)]
        public static UnaryEval<T> unary<T>(in Span<T> src, in PairEval<T> dst)
            where T : unmanaged
                => new UnaryEval<T>(src, dst);

        [MethodImpl(Inline)]
        public static BinaryEval<T> binary<T>(in Pairs<T> src, in PairEval<T> dst)
            where T : unmanaged
                => new BinaryEval<T>(src,  dst);

        [MethodImpl(Inline)]
        public static PairEval<T> pairs<T>(Pair<string> labels, in Pairs<T> dst)
            where T : unmanaged
                => new PairEval<T>(labels, dst);                

    }
}