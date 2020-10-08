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

    partial struct Db
    {
        public readonly struct Key
        {
            readonly ulong Data;

            [MethodImpl(Inline)]
            public Key(ulong src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator Key(ObjectName src)
                => new Key(src.Ref.Address);
        }

        public readonly struct Key<T>
            where T : unmanaged
        {
            readonly T Data;

            [MethodImpl(Inline)]
            public Key(T src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator Key<T>(T src)
                => new Key<T>(src);
        }
    }
}