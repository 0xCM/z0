//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct Eval
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryEvaluations<T> unary<T>(in Span<T> src, in PairEvalResults<T> dst)
            where T : unmanaged
                => new UnaryEvaluations<T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryEvaluations<T> binary<T>(in Pairs<T> src, in PairEvalResults<T> dst)
            where T : unmanaged
                => new BinaryEvaluations<T>(src, dst);
    }
}