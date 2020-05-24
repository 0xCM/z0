//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using W = AsmFieldWidths;
    using I = OperandCountId;
    using R = OperandCountRecord;
    using F = OperandCountField;

    public enum OperandCountId
    {
        Sequence,

        Count,

        Id,
    }

    public enum OperandCountField
    {
        Sequence = I.Sequence | W.Sequence << W.Offset,

        Count = I.Count | W.Count << W.Offset,

        Id = I.Id | W.Id << W.Offset,
    }

    public readonly struct OperandCountRecord : IRecord<F,R>
    {        
        [MethodImpl(Inline)]
        public OperandCountRecord(int Sequence, byte Count, OpCodeId Id)
        {
            this.Sequence  = Sequence;
            this.Count = Count;
            this.Id = Id;
        }

        public int Sequence {get;}

        public byte Count {get;}

        public OpCodeId Id {get;}

        public string DelimitedText(char delimiter)
        {
            var dst = RecordFormatter<F>.Service;
            dst.AppendField(F.Sequence, Sequence,delimiter);
            dst.AppendField(F.Count, Count, delimiter);
            dst.AppendField(F.Id, Id, delimiter);
            return dst.ToString();
        }
    }
}