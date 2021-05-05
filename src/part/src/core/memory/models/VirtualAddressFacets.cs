//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    // See https://cs61.seas.harvard.edu/site/2018/Kernel3/
    public readonly struct VirtualAddressFacets
    {
        public const Pow2x16 PageSize = Pow2x16.P2ᐞ12;

        public const byte OffsetWidth = 12;

        public const byte LevelWidth = 9;

        public const byte OffsetMsb = OffsetWidth - 1;

        public const byte L1_Lsb = OffsetWidth;

        public const byte L1_Msb = L1_Lsb + LevelWidth;

        public const byte L2_Lsb = L1_Msb + 1;

        public const byte L2_Msb = L2_Lsb + LevelWidth;

        public const byte L3_Lsb = L2_Msb + 1;

        public const byte L3_Msb = L3_Lsb + LevelWidth;

        public const byte L4_Lsb = L3_Msb + 1;

        public const byte L4_Msb = L4_Lsb + LevelWidth;

        public const ulong OffsetMask = 0b1111_1111_1111;

        public const ulong LevelMask = byte.MaxValue;

        public const ulong L1_Mask = LevelMask << 1*OffsetWidth;

        public const ulong L2_Mask = LevelMask << 2*OffsetWidth;

        public const ulong L3_Mask = LevelMask << 3*OffsetWidth;

        public const ulong L4_Mask = LevelMask << 4*OffsetWidth;

        public const ulong LoMin = 0x0000_0000_0000_0000;

        public const ulong LoMax = 0x0000_7FFF_FFFF_FFFF;

        public const ulong HiMin = 0xFFFF_8000_0000_0000;

        public const ulong HiMax = 0xFFFF_FFFF_FFFF_FFFF;
    }
}