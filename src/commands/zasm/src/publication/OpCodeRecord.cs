//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    using R = OpCodeRecord;
    using F = OpCodeRecordField;

    public enum OpCodeRecordField
    {
        Sequence = 0,

        Mnemonic = 1,

        Expression = 2,

        Instruction = 3,

        M16,

        M32,

        M64,

        CpuId,

        Id,
   
    }

    public readonly struct OpCodeRecord : IRecord<F,R>
    {
        
        public OpCodeRecord(int Sequence, OpCodeId Id, string Mnemonic, string Expression, string Instruction, YeaOrNea M16, YeaOrNea M32, YeaOrNea M64, string CpuId)
        {
            this.Seq = Sequence;
            this.Id = Id;
            this.Mnemonic = Mnemonic;
            this.Expression = Expression;
            this.Instruction = Instruction;
            this.M16 = M16;
            this.M32 = M32;
            this.M64 = M64;
            this.CpuId = CpuId;
        }

        public readonly int Seq;

        public int Sequence 
            => Seq;

        public string Mnemonic {get;}

        public string Expression {get;}

        public string Instruction {get;}

        public YeaOrNea M16 {get;}

        public YeaOrNea M32 {get;}

        public YeaOrNea M64 {get;}

        public string CpuId {get;}

        public OpCodeId Id {get;}
    }

    public readonly struct OpCodeRecords
    {
        readonly OpCodeRecord[] Data;
        
        public static OpCodeRecords From(OpCodeRecord[] src)
            => new OpCodeRecords(src);
        
        public OpCodeRecords(OpCodeRecord[] src)
        {
            Data = src;
        }

        public OpCodeRecord this[OpCodeId id]
        {
            get => Data[(int)id];
        }    
    }
}