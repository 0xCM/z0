//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System.Runtime.CompilerServices;

    using static Root;

    public struct CmpPred128<T> : ICmpPred<__m128i<T>>
        where T : unmanaged
    {
        public CmpKind Kind {get;}

        public __m128i<T> A {get;}

        public __m128i<T> B {get;}

        [MethodImpl(Inline)]
        public CmpPred128(CmpKind kind, __m128i<T> a, __m128i<T> b)
        {
            Kind = kind;
            A = a;
            B = b;
        }

        public string Format()
        {
            var syms = Symbols.index<CmpKind>();
            var sym = syms[Kind].Expr;
            return string.Format("{0} {1} {2}", A, sym, B);
        }

        public override string ToString()
            => Format();
    }

}