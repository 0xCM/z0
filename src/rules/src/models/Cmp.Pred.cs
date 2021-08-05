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
        public readonly struct CmpPred<T> : ICmpPred<CmpPred<T>,T>
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

            public string Format()
                => CmpPreds.format(this);

            public override string ToString()
                => Format();

        }
    }
}