//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct NLT<T> : ICmpPred<T>
    {
        public T A {get;}

        public T B {get;}

        [MethodImpl(Inline)]
        public NLT(T a, T b)
        {
            A = a;
            B = b;
        }

        public SymExpr Symbol
        {
            [MethodImpl(Inline)]
            get => CmpSymbolExpr.NLT;
        }

        public CmpKind Kind
            => CmpKind.NLT;

        [MethodImpl(Inline)]
        public string Format()
            => api.format<T>(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator NLT<T>((T a, T b) src)
            => new NLT<T>(src.a, src.b);

        [MethodImpl(Inline)]
        public static implicit operator CmpPred<T>(NLT<T> src)
            => new CmpPred<T>(src.A,src.B,src.Kind);
    }
}