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
        public readonly struct GTE<T> : ICmpPred<GTE<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public GTE(T a, T b)
            {
                A = a;
                B = b;
            }

            public string Symbol
            {
                [MethodImpl(Inline)]
                get => CmpSymbol.GTE;
            }

            public CmpKind Kind
                => CmpKind.GTE;


            [MethodImpl(Inline)]
            public string Format()
                => CmpPreds.format<T>(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator GTE<T>((T a, T b) src)
                => new GTE<T>(src.a, src.b);

            [MethodImpl(Inline)]
            public static implicit operator CmpPred<T>(GTE<T> src)
                => new CmpPred<T>(src.A,src.B,src.Kind);
        }
    }
}