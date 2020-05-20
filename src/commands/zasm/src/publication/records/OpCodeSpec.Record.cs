//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Data;

    using static Seed;

    public readonly struct OpCodeSpec
    {           
        public static OpCodeSpec Empty 
            => new OpCodeSpec(0,OpCodeId.INVALID, nameof(OpCodeId.INVALID), string.Empty, string.Empty,string.Empty,string.Empty);
        
        public int Sequence {get;}
        
        public readonly OpCodeId Id;
		
		public readonly string Mnemonic;
		
		public readonly string Instruction;

		public readonly string Expression;

		public readonly string Modes;

		public readonly string CpuId;

        [MethodImpl(Inline)]
        public OpCodeSpec(int Sequence, OpCodeId Id, string Mnemonic, string Instruction, string Expression, string Modes, string CpuId)
        {
            this.Sequence = Sequence;
            this.Id = Id;
            this.Mnemonic = Mnemonic;
            this.Instruction = Instruction;
            this.Expression = Expression;
            this.Modes = Modes;
            this.CpuId = CpuId;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Sequence == 0 && Id == OpCodeId.INVALID;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}