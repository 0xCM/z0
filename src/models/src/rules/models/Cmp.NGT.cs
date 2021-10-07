//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        public readonly struct NGT<T> : ICmpPred<T>
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public NGT(T a, T b)
            {
                A = a;
                B = b;
            }

            public SymExpr Symbol
            {
                [MethodImpl(Inline)]
                get => CmpSymbolExpr.NGT;
            }

            public CmpKind Kind
                => CmpKind.NGT;

            [MethodImpl(Inline)]
            public string Format()
                => api.format<T>(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator NGT<T>((T a, T b) src)
                => new NGT<T>(src.a, src.b);

            [MethodImpl(Inline)]
            public static implicit operator CmpPred<T>(NGT<T> src)
                => new CmpPred<T>(src.A,src.B,src.Kind);
        }
    }
}