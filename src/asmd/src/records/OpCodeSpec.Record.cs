//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using F = OpCodeSpecField;
    using R = OpCodeSpec;

    public struct OpCodeSpec : IRecord<F,R>
    {                   
        public static OpCodeSpec Empty 
            => new OpCodeSpec(0,OpCodeId.INVALID, nameof(OpCodeId.INVALID), string.Empty, string.Empty, 
                YeaOrNea.N, YeaOrNea.N,YeaOrNea.N,string.Empty);
        
        [MethodImpl(Inline)]
        public static YeaOrNea yn(bool src) 
            => src ? YeaOrNea.Y : YeaOrNea.N;

        public int Seq;

        public int Sequence => Seq;
        
        public OpCodeId Id;
		
		public string Mnemonic;
		
		public string Instruction;

		public string Expression;

		public YeaOrNea M16;

		public YeaOrNea M32;

		public YeaOrNea M64;
        
		public string CpuId;

        public YeaOrNea RexW 
            => yn(Expression.Contains("REX.W"));

        public YeaOrNea Vex 
            => yn(Expression.StartsWith("VEX."));

        public YeaOrNea Xop 
            => yn(Expression.StartsWith("XOP."));

        public YeaOrNea Evex 
            => yn(Expression.StartsWith("EVEX."));

        [MethodImpl(Inline)]
        public OpCodeSpec(int Seq, OpCodeId Id, string Mnemonic, string Instruction, string Expression, YeaOrNea M16, YeaOrNea M32, YeaOrNea M64, string CpuId)
        {
            this.Seq = Seq;
            this.Id = Id;
            this.Mnemonic = Mnemonic;
            this.Instruction = Instruction;
            this.Expression = Expression;
            this.M16 = M16;
            this.M32 = M32;
            this.M64 = M64;
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