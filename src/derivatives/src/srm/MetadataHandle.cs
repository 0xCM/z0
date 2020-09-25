//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MetadataHandle<T>
    {
        public readonly T Data;

        [MethodImpl(Inline)]
        public MetadataHandle(T src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator MetadataHandle<T>(T src)
            => new MetadataHandle<T>(src);
    }
}