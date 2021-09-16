//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static MemorySections;

    using api = MemorySections;

    [ApiHost]
    public readonly partial struct BssSections : ISectionDispenser<BssSections>
    {
        const uint _EntryCount = 4;

        [Op]
        public static BssSections dispenser()
            => new BssSections(_ContainerAddress);

        MemoryAddress ContainerAddress {get;}

        [MethodImpl(Inline)]
        BssSections(MemoryAddress @base)
        {
            ContainerAddress = @base;
        }

        public uint EntryCount => _EntryCount;

        [MethodImpl(Inline), Op]
        public unsafe ref readonly SectionEntry Entry(ushort index)
            => ref Container()[index];

        [Op]
        public ReadOnlySpan<SectionEntry> Entries()
            => Container().View;

        [Op]
        uint ISectionDispenser.EntryCount
            => _EntryCount;

        [Op]
        SectionEntry ISectionDispenser.Entry(ushort id)
            => Entry(id);

        [Op]
        ReadOnlySpan<SectionEntry> ISectionDispenser.Entries()
            => Entries();

        [MethodImpl(Inline), Op]
        ref readonly Index<SectionEntry> Container()
            => ref Index.from<SectionEntry>(ContainerAddress);

        [Op]
        static uint initialize(Span<SectionEntry> dst)
        {
            seek(dst,0) = entry(default(Bss1x16x16x64_0));
            seek(dst,1) = entry(default(Bss1x16x16x64_1));
            seek(dst,2) = entry(default(Bss1x16x16x64_2));
            seek(dst,3) = entry(default(Bss1x16x16x64_3));
            api.initialize(skip(dst,0));
            api.initialize(skip(dst,1));
            api.initialize(skip(dst,2));
            api.initialize(skip(dst,3));
            return _EntryCount;
        }

        [FixedAddressValueType]
        static Index<SectionEntry> _Container;

        static MemoryAddress _ContainerAddress;

        static BssSections()
        {
            _Container = alloc<SectionEntry>(_EntryCount);
            initialize(_Container.Edit);
            _ContainerAddress = address(_Container);
        }
    }
}