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

    public struct BinaryJudgement<T> : IBinaryJudgement<T>
    {
        public T A;

        public T B;

        public bit Success;

        [MethodImpl(Inline)]
        public BinaryJudgement(T a, T b, bit success)
        {
            A = a;
            B = b;
            Success = success;
        }

        T IBinaryJudgement<T>.A
            => A;

        T IBinaryJudgement<T>.B
            => B;

        bit IJudgement.Result
            => Success;

        [MethodImpl(Inline)]
        public static bool operator true(BinaryJudgement<T> src)
            => src.Success;

        [MethodImpl(Inline)]
        public static bool operator false(BinaryJudgement<T> src)
            => !src.Success;
    }
}