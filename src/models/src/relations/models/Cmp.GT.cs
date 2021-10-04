//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Relations
    {
        public readonly struct GT<T> : ICmpPred<T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public GT(T a, T b)
            {
                A = a;
                B = b;
            }

            public SymExpr Symbol
            {
                [MethodImpl(Inline)]
                get => CmpSymbolExpr.GT;
            }

            public CmpKind Kind
                => CmpKind.GT;

            [MethodImpl(Inline)]
            public string Format()
                => format<T>(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator GT<T>((T a, T b) src)
                => new GT<T>(src.a, src.b);

            [MethodImpl(Inline)]
            public static implicit operator CmpPred<T>(GT<T> src)
                => new CmpPred<T>(src.A,src.B,src.Kind);
        }
    }
}