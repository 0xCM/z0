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

    public readonly struct RelationKey
    {
        readonly ulong Id;

        [MethodImpl(Inline)]
        public RelationKey(ulong src)
            => Id = src;

        [MethodImpl(Inline)]
        public static implicit operator RelationKey(ObjectName src)
            => new RelationKey(src.Surrogate);
    }

    public readonly struct RelationKey<T>
        where T : unmanaged
    {
        readonly T Data;

        [MethodImpl(Inline)]
        public RelationKey(T src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator RelationKey<T>(T src)
            => new RelationKey<T>(src);
    }
}