//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using F = OpCodeField;
    using R = OpCodeRecord;

    public struct OpCodeRecord : IRecord<F,R>
    {                   
        public static OpCodeRecord Empty 
            => new OpCodeRecord(0,OpCodeId.INVALID, nameof(OpCodeId.INVALID), string.Empty, string.Empty, 
                YeaOrNea.N, YeaOrNea.N,YeaOrNea.N,string.Empty);        
        
        public int Sequence => Seq;
        
        public int Seq;
        
        public OpCodeId Id;
		
		public string Mnemonic;
		
		public string Instruction;

		public string Expression;

		public YeaOrNea M16;

		public YeaOrNea M32;

		public YeaOrNea M64;
        
		public string CpuId;

        [MethodImpl(Inline)]
        public OpCodeRecord(int Seq, OpCodeId Id, string Mnemonic, string Instruction, string Expression, YeaOrNea M16, YeaOrNea M32, YeaOrNea M64, string CpuId)
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

        public string Format()
        {
            var formatter = Records.Formatter<F>();
            formatter.DelimitField(F.Sequence, Seq);
            formatter.DelimitField(F.Id, Id);
            formatter.DelimitField(F.Mnemonic, Mnemonic);
            formatter.DelimitField(F.Instruction, Instruction);
            formatter.DelimitField(F.Expression, Expression);
            formatter.DelimitField(F.M16, M16);
            formatter.DelimitField(F.M32, M32);
            formatter.DelimitField(F.M64, M64);
            formatter.DelimitField(F.CpuId, CpuId);
            return formatter.ToString();

        }
    }
}