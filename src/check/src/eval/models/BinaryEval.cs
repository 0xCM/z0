//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct BinaryEval<T> : IBinaryEval<T>
    {
        public T A {get;}

        public T B {get;}

        public bit Result {get;}

        [MethodImpl(Inline)]
        public BinaryEval(T a, T b, bit success)
        {
            A = a;
            B = b;
            Result = success;
        }

        [MethodImpl(Inline)]
        public static bool operator true(BinaryEval<T> src)
            => src.Result;

        [MethodImpl(Inline)]
        public static bool operator false(BinaryEval<T> src)
            => !src.Result;
    }
}