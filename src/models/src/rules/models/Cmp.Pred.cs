//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System.Runtime.CompilerServices;

    using static Root;

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