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

            public const byte FieldCount = 10;

            public uint OpCodeId;

            public CharBlock16 Mnemonic;

            public CharBlock48 Expr;

            public CharBlock64 Sig;

            public CharBlock8 EncXRef;

            //public Mode64Kind Mode64;

            public CharBlock8 Mode64Expr;

            //public LegacyModeKind LegacyMode;

            public CharBlock8 LegacyModeExpr;

            //public Mode64x32Kind Mode64x32;

            public CharBlock8 Mode64x32Expr;

            //public CpuIdFeature CpuId;

            public CharBlock16 CpuIdExpr;

            public CharBlock256 Description;

            public static ReadOnlySpan<byte> RenderWidths
                => new byte[FieldCount]{12,16,48,64,8,8,8,8,16,255};
        }
    }
}