//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1), Record(TableId)]
    public struct LlvmOpCodeSpec : IRecord<LlvmOpCodeSpec>, IComparable<LlvmOpCodeSpec>
    {
        public const string TableId = "llvm.opcodes";

        public const byte FieldCount = 5;

        public ushort Index;

        public CharBlock32 OpId;

        public CharBlock16 Mnemonic;

        public Hex64 OpCodeValue;

        public CharBlock24 OpCodeBytes;

        public int CompareTo(LlvmOpCodeSpec other)
            => (OpId as IComparable<CharBlock32>).CompareTo(other.OpId);

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{8,32,16,16,24};
    }
}