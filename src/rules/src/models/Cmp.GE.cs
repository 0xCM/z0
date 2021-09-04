//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct GE<T> : ICmpPred<GE<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public GE(T a, T b)
            {
                A = a;
                B = b;
            }

            public string Symbol
            {
                [MethodImpl(Inline)]
                get => CmpSymbol.GE;
            }

            public CmpKind Kind
                => CmpKind.GE;


            [MethodImpl(Inline)]
            public string Format()
                => format<T>(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator GE<T>((T a, T b) src)
                => new GE<T>(src.a, src.b);

            [MethodImpl(Inline)]
            public static implicit operator CmpPred<T>(GE<T> src)
                => new CmpPred<T>(src.A,src.B,src.Kind);
        }
    }
}