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

    public readonly struct DbKey
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        public DbKey(ulong src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator DbKey(Db.ObjectName src)
            => new DbKey(src.Ref.Address);
    }

    public readonly struct DbKey<T>
        where T : unmanaged
    {
        readonly T Data;

        [MethodImpl(Inline)]
        public DbKey(T src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator DbKey<T>(T src)
            => new DbKey<T>(src);
    }
}