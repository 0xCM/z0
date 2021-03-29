//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IMemBlockG<T>
        where T : unmanaged, IMemBlock<T>
    {
        Span<T> Data => memory.recover<byte,T>(memory.bytes((T)this));

    }

    public interface IMemBlock<T> : IMemBlockG<T>
        where T : unmanaged, IMemBlock<T>
    {
        ByteSize Size => memory.size<T>();

        Span<byte> Bytes => memory.bytes((T)this);
    }
}