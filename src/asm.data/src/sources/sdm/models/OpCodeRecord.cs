//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    partial struct SdmModels
    {
        [StructLayout(LayoutKind.Sequential), Record(TableId)]
        public struct OpCodeRecord : IRecord<OpCodeRecord>
        {
            public const string TableId = "sdm.opcodes";

            public uint OpCodeId;

            public CharBlock16 Mnemonic;

            public CharBlock48 Expr;

            public CharBlock64 Sig;

            public EncodingCrossRef EncodingRef;

            public Mode64Kind Mode64;

            public LegacyModeKind LegacyMode;

            public Mode64x32Kind Mode64x32;

            public CpuIdFeature CpuId;

            public TextBlock Description;
        }
    }
}