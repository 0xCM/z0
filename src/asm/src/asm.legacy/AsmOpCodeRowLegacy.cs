//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record(TableId)]
    public struct AsmOpCodeRowLegacy : IRecord<AsmOpCodeRowLegacy>
    {
        public const string TableId = "asm.legacy-opcodes";

        public int Sequence;

		public asci32 Mnemonic;

		public asci32 OpCode;

        public asci64 Instruction;

        public bit M16;

        public bit M32;

        public bit M64;

		public asci64 CpuId;

        public IceOpCodeId CodeId;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Sequence == 0 && CodeId == IceOpCodeId.INVALID;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static AsmOpCodeRowLegacy Empty
            => default;
    }
}