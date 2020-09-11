//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = OperatorClassKind;

    public readonly struct OperatorClass : IOperatorClass<OperatorClass,K>
    {
        public K Kind {get;}

        [MethodImpl(Inline)]
        public OperatorClass(K k)
            => Kind = k;

        public OperatorClass Generalized
            => new OperatorClass(Kind);
    }

    public readonly struct OperatorClass<T> : IOperational<K,T>
    {
        public K Kind {get;}

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(OperatorClass<T> src)
            => new OperatorClass(src.Kind);

        [MethodImpl(Inline)]
        public OperatorClass(K k)
            => Kind = k;
    }
}