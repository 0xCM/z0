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

            public string Format()
                 => api.format<T>(this);

            public override string ToString()
                => Format();
        }
    }
}