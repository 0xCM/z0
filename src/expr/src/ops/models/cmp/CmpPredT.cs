//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CmpPred<T> : ICmpPred<CmpPred<T>,T>
        where T : IExpr
    {
        public T A {get;}

        public T B {get;}

        public CmpPredKind Kind {get;}

        [MethodImpl(Inline)]
        public CmpPred(T a, T b, CmpPredKind kind)
        {
            A = a;
            B = b;
            Kind = kind;
        }

        public Label OpName => "cmp<{0}>";

        public string Format()
            => scalars.format<T>(this);

        public override string ToString()
            => Format();

        public CmpPred<T> Make(T a0, T a1)
            => default;
    }
}