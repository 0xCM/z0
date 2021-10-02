//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
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