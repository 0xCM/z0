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
    }
}