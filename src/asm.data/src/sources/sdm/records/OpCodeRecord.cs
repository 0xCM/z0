//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using System.Runtime.InteropServices;

    partial struct SdmRecords
    {
        [StructLayout(LayoutKind.Sequential), Record(TableId)]
        public struct OpCodeRecord : IRecord<OpCodeRecord>
        {
            public const string TableId = "sdm.opcodes";

            public const byte FieldCount = 14;

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

            public CharBlock256 Description;

            public static ReadOnlySpan<byte> RenderWidths
                => new byte[FieldCount]{
                    12,16,48,64,
                    10,10,10,10,
                    16,6,6,6,6,
                    255};
        }
    }
}