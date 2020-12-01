//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct InPair<T>
        where T : unmanaged
    {
        public T A {get;}

        public T B {get;}


        [MethodImpl(Inline)]
        public InPair(T x, T y)
        {
            A = x;
            B = y;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out T x, out T y)
        {
            x = A;
            y = B;
        }

        [MethodImpl(Inline)]
        public static implicit operator (T x, T y)(InPair<T> src)
            => (src.A, src.B);

        [MethodImpl(Inline)]
        public static implicit operator InPair<T>(OutPair<T> src)
            => new InPair<T>(src.A,src.B);

        [MethodImpl(Inline)]
        public static implicit operator InPair<T> ((T x, T y) src)
            => new InPair<T>(src.x, src.y);
    }
}