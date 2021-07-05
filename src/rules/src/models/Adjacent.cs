//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Adjacent
        {
            public dynamic A {get;}

            public dynamic B {get;}

            [MethodImpl(Inline)]
            public Adjacent(dynamic a, dynamic b)
            {
                A = a;
                B = b;
            }
        }

        /// <summary>
        /// Represents the consecutive occurrence of two values
        /// </summary>
        public readonly struct Adjacent<T> : IRule<Adjacent<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public Adjacent(T a, T b)
            {
                A = a;
                B = b;
            }

            public string Format()
                => string.Format(RP.Adjacent2, A, B);


            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Adjacent<T>((T left, T right) src)
                => new Adjacent<T>(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Adjacent<T>(Pair<T> src)
                => new Adjacent<T>(src.Left, src.Right);

            [MethodImpl(Inline)]
            public static implicit operator Adjacent(Adjacent<T> src)
                => new Adjacent(src.A, src.B);
        }

        public readonly struct Adjacent<S,T> : IRule<Adjacent<S,T>,S,T>
        {
            public S A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public Adjacent(S a, T b)
            {
                A = a;
                B = b;
            }

            public string Format()
                => string.Format(RP.Adjacent2, A, B);


            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Adjacent<S,T>((S left, T right) src)
                => new Adjacent<S,T>(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Adjacent<S,T>(Paired<S,T> src)
                => new Adjacent<S,T>(src.Left, src.Right);

            [MethodImpl(Inline)]
            public static implicit operator Adjacent(Adjacent<S,T> src)
                => new Adjacent(src.A, src.B);
        }
    }
}