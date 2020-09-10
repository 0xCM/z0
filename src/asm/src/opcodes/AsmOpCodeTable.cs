//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = AsmOpCodeField;
    using R = AsmOpCodeTable;
    using api = AsmOpCodes;

    public struct AsmOpCodeTable : ITable<F,R>
    {
        public int Sequence;

		public asci32 Mnemonic;

		public asci32 OpCode;

        public asci64 Instruction;

        public YeaOrNea M16;

        public YeaOrNea M32;

        public YeaOrNea M64;

		public asci64 CpuId;

        public OpCodeId CodeId;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Sequence == 0 && CodeId == OpCodeId.INVALID;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static AsmOpCodeTable Empty
            => default;
    }
}