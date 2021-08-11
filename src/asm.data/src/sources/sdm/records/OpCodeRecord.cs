//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential), Record(TableId), Blittable]
    public struct SdmOpCodeRecord : IRecord<SdmOpCodeRecord>, IComparable<SdmOpCodeRecord>
    {
        public const string TableId = "sdm.opcodes";

        public const byte FieldCount = 14;

        public const uint StorageSize =
            PrimalSizes.U32 +
            CharBlock16.Size +
            CharBlock48.Size +
            CharBlock64.Size +
            4*CharBlock8.StorageSize +
            CharBlock16.Size +
            4*bit.StorageSize +
            CharBlock254.StorageSize
            ;

        public uint OpCodeId;

        public CharBlock16 Mnemonic;

        public CharBlock48 OpCode;

        public CharBlock64 Sig;

        public CharBlock8 EncXRef;

        public CharBlock8 Mode64;

        public CharBlock8 LegacyMode;

        public CharBlock8 Mode64x32;

        public CharBlock16 CpuId;

        public bit Rex;

        public bit RexW;

        public bit Vex;

        public bit Evex;

        public CharBlock254 Description;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{
                12,16,48,64,
                10,10,10,10,
                16,6,6,6,6,
                254};

        public int CompareTo(SdmOpCodeRecord src)
            => Sig.String.CompareTo(src.Sig.String, NoCase);
    }
}