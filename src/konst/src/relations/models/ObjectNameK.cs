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

    public readonly struct ObjectName<K>
        where K : unmanaged
    {
        readonly string Interned;

        public K Kind {get;}

        [MethodImpl(Inline)]
        public ObjectName(string id, K kind)
        {
            Interned = id;
            Kind = kind;
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Interned;
        }

        public ulong Surrogate
        {
            [MethodImpl(Inline)]
            get => address(Interned);
        }

        [MethodImpl(Inline)]
        public static implicit operator ObjectName<K>((string id, K kind) x)
            => new ObjectName<K>(x.id, x.kind);
    }
}