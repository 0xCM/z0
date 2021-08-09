//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static MemorySections;

    [Free]
    public interface IMemorySection
    {
        ushort Index {get;}

        MemoryAddress Base();

        SectionCapacity Capacity();
    }

    [Free]
    public interface IMemorySection<T> : IMemorySection
        where T : unmanaged, IMemorySection<T>
    {
    }

    [Free]
    public interface ISectionEntry : IMemorySection, ITextual
    {
        Span<byte> Storage();

        Span<T> Storage<T>()
            where T : unmanaged;

        SectionDescriptor Descriptor();

        ByteSize SegSize
            => Capacity().SegSize;

        byte SegScale
            => Capacity().SegsPerBlock;

        uint BlockCount
            => Capacity().BlockCount;

        ByteSize BlockSize
            => Capacity().BlockSize;

        ByteSize TotalSize
            => Capacity().TotalSize;
    }

    [Free]
    public interface ISectionEntry<T> : IMemorySection<T>, ISectionEntry
        where T : unmanaged, IMemorySection<T>
    {

    }

    [Free]
    public interface ISectionDispenser
    {
        uint EntryCount {get;}

        SectionEntry Entry(ushort id);

        ReadOnlySpan<SectionEntry> Entries();
    }

    [Free]
    public interface ISectionDispenser<T> : ISectionDispenser
        where T : ISectionDispenser<T>
    {

    }
}