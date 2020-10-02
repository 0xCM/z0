//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct WfCmdOption<K,T>
        where K : unmanaged
    {
        public K Kind {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public WfCmdOption(K kind, T value)
        {
            Kind = kind;
            Value = value;
        }

        public static implicit operator WfCmdOption<K,T>((K kind, T value) src)
            => new WfCmdOption<K,T>(src.kind, src.value);
    }
}