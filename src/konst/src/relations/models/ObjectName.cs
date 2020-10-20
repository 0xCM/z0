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

    public readonly struct ObjectName
    {
        readonly string Interned;

        [MethodImpl(Inline)]
        public ObjectName(string src)
            => Interned = src;

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Interned;
        }

        [MethodImpl(Inline)]
        public static implicit operator ObjectName(string src)
            => new ObjectName(src);

        public ulong Surrogate
        {
            [MethodImpl(Inline)]
            get => address(Interned);
        }
    }

    public readonly struct ObjectName<K>
        where K : unmanaged
    {
        readonly string Interned;

        public K Kind {get;}

        [MethodImpl(Inline)]
        public ObjectName(K kind, string id)
        {
            Kind = kind;
            Interned = id;
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Interned;
        }

        [MethodImpl(Inline)]
        public static implicit operator ObjectName<K>((K kind, string id) x)
            => new ObjectName<K>(x.kind, x.id);

        public ulong Surrogate
        {
            [MethodImpl(Inline)]
            get => address(Interned);
        }
    }
}
