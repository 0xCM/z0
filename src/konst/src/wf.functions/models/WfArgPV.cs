//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct WfArg<P,V>
    {
        public P Param {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public WfArg(P p, V v)
        {
            Param = p;
            Value = v;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfArg<P,V>((P param, V value) src)
            => new WfArg<P,V>(src.param, src.value);

        public static WfArg<P,V> Empty
            => default;
    }
}