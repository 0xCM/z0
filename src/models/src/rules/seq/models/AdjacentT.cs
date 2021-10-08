//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = SeqRules;

    partial struct SeqRules
    {
        /// <summary>
        /// Represents the consecutive occurrence of two values within a sequence
        /// </summary>
        public readonly struct Adjacent<T>
        {
            public readonly T A;

            public readonly T B;

            [MethodImpl(Inline)]
            public Adjacent(T a, T b)
            {
                A = a;
                B = b;
            }

            public string Format()
                => SeqRules.format(this);


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