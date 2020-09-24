//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public readonly struct WfArg<P,V>
    {
        public readonly P Param;

        public readonly V Value;

        [MethodImpl(Inline)]
        public static implicit operator WfArg<P,V>((P param, V value) src)
            => new WfArg<P,V>(src.param, src.value);

        [MethodImpl(Inline)]
        public WfArg(P p, V v)
        {
            Param = p;
            Value = v;
        }

        public static WfArg<P,V> Empty
            => new WfArg<P,V>(default(P), default(V));
    }

}