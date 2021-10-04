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
        public readonly struct CmpPred<T> : ICmpPred<T>
        {
            public T A {get;}

            public T B {get;}

            public CmpKind Kind {get;}

            [MethodImpl(Inline)]
            public CmpPred(T a, T b, CmpKind kind)
            {
                A = a;
                B = b;
                Kind = kind;
            }

            public SymExpr Symbol
            {
                get => default;
            }

            public string Format()
                => format<T>(this);

            public override string ToString()
                => Format();
        }
    }
}