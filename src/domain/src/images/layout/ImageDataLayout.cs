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
    using api = DataLayouts;

    using F = ImageDataLayout.SectionHeaderField;

    [ApiHost]
    public partial struct ImageDataLayout
    {
        [Op]
        public static SegmentSpec SectionHeader(uint index)
        {
            const uint Count = 6;
            var spec = api.segment(index, 0, z.alloc<SegmentPartition>(Count));
            ref var dst = ref spec.FirstSection;
            var ix = 0u;
            section(ref dst, ref ix, F.Name, 0, 8);
            section(ref dst, ref ix, F.VirtualSize, 8, 4);
            section(ref dst, ref ix, F.VirtualAddress, 12, 4);
            section(ref dst, ref ix, F.SizeOfRawData, 16, 4);
            section(ref dst, ref ix, F.PointerToRawData, 20, 4);
            section(ref dst, ref ix, F.PointerToRelocations, 24, 4);
            return spec;
        }

        [MethodImpl(Inline), Op]
        internal static void section<T>(ref SegmentPartition head, ref uint index, T kind, ulong offset, ByteSize size)
        {
            var left = offset*8;
            var right = size.Bits + left - 1;
            seek(head, index) = new SegmentPartition(api.identify(index, uint64(kind)), left, right);
            index++;
        }

        public enum SectionHeaderField : byte
        {
            Name = 0,

            VirtualSize,

            VirtualAddress,

            SizeOfRawData,

            PointerToRawData,

            PointerToRelocations,

            PointerToLinenumbers,

            NumberOfRelocations,

            NumberOfLinenumbers,

            Characteristics
        }
    }
}