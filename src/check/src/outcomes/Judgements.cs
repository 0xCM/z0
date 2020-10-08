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

    [ApiHost]
    public readonly partial struct Judgements
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryJudgement<T> binary<T>(T a, T b, bit result)
            => new BinaryJudgement<T>(a,b,result);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static SequenceJudgement<T> sequence<T>(BinaryJudgement<T>[] src)
            => new SequenceJudgement<T>(src);
    }
}