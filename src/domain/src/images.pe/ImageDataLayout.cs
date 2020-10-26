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
        public static DataLayout<F> SectionHeader(uint index)
        {
            const uint Count = 6;
            var spec = DataLayouts.specify<F>(index, 0);
            ref var dst = ref spec.FirstPartition;
            var ix = 0u;
            api.partition(ref dst, ref ix, F.Name, 0, 8);
            api.partition(ref dst, ref ix, F.VirtualSize, 8, 4);
            api.partition(ref dst, ref ix, F.VirtualAddress, 12, 4);
            api.partition(ref dst, ref ix, F.SizeOfRawData, 16, 4);
            api.partition(ref dst, ref ix, F.PointerToRawData, 20, 4);
            api.partition(ref dst, ref ix, F.PointerToRelocations, 24, 4);
            return spec;
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