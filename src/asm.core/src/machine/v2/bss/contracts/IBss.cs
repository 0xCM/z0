//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBss
    {
        ushort Id {get;}

        MemoryAddress Base();

        MemCapacity Capacity();

    }

    [Free]
    public interface IBss<T> : IBss
        where T : unmanaged, IBss<T>
    {
    }

    [Free]
    public interface IBssEntry : IBss, ITextual
    {
        Span<byte> Storage();

        Span<T> Storage<T>()
            where T : unmanaged;

        BssDescriptor Descriptor();

        ByteSize SegSize => Capacity().SegSize;

        byte SegScale => Capacity().BlockSegs;

        uint BlockCount => Capacity().BlockCount;

        ByteSize BlockSize => Capacity().BlockSize;

        ByteSize TotalSize => Capacity().TotalSize;
    }

    [Free]
    public interface IBssEntry<T> : IBss<T>, IBssEntry
        where T : unmanaged, IBss<T>
    {

    }
}