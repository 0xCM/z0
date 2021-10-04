//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Relations
    {
        public readonly struct EQ<T> : ICmpPred<T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public EQ(T a, T b)
            {
                A = a;
                B = b;
            }

            public SymExpr Symbol
            {
                [MethodImpl(Inline)]
                get => CmpSymbolExpr.EQ;
            }

            public CmpKind Kind
                => CmpKind.EQ;

            [MethodImpl(Inline)]
            public string Format()
                => format<T>(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator EQ<T>((T a, T b) src)
                => new EQ<T>(src.a, src.b);

            [MethodImpl(Inline)]
            public static implicit operator CmpPred<T>(EQ<T> src)
                => new CmpPred<T>(src.A,src.B,src.Kind);
        }
    }
}