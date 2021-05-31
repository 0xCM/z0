//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public interface IDataBlock<T>
        where T : unmanaged, IDataBlock<T>
    {
        Span<T> Data
            => recover<byte,T>(bytes((T)this));

        ByteSize Size
            => size<T>();

        Span<byte> Bytes
            => bytes((T)this);
    }
}