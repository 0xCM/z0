//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDataBlock<T>
        where T : unmanaged, IDataBlock<T>
    {
        Span<T> Data
            => memory.recover<byte,T>(memory.bytes((T)this));

        ByteSize Size
            => memory.size<T>();

        Span<byte> Bytes
            => memory.bytes((T)this);
    }
}