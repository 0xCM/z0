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
        public readonly struct LTE<T> : ICmpPred<LTE<T>,T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public LTE(T a, T b)
            {
                A = a;
                B = b;
            }

            public string Symbol
            {
                [MethodImpl(Inline)]
                get => CmpSymbol.LTE;
            }


            public CmpKind Kind
                => CmpKind.LTE;

            [MethodImpl(Inline)]
            public string Format()
                => CmpPreds.format<T>(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator LTE<T>((T a, T b) src)
                => new LTE<T>(src.a, src.b);

            [MethodImpl(Inline)]
            public static implicit operator CmpPred<T>(LTE<T> src)
                => new CmpPred<T>(src.A,src.B,src.Kind);
        }
    }
}