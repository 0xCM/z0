//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public interface IStorageBlock<T>
        where T : unmanaged, IStorageBlock<T>
    {
        ByteSize Size
            => size<T>();

        Span<byte> Bytes
            => bytes((T)this);
    }
}