//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using F = CapturedEncodingField;
    using R = CapturedEncodingRecord;

    public enum CapturedEncodingField : ulong
    {
        Sequence = 0 | 10ul << 32,

        Address = 1 | 16ul << 32,

        Length = 2 | 8ul << 32,

        Uri = 3 | 110ul << 32,

        OpSig = 4 | 110ul << 32,

        Data = 5 | 1ul << 32
    }

    public readonly struct CapturedEncodingRecord : IRecord<F, R>
    {
        public CapturedEncodingRecord(int Sequence, MemoryAddress Address, int Length, OpUri Uri, string OpSig, EncodedData Data)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.Length = Length; 
            this.Uri = Uri;
            this.OpSig = OpSig;
            this.Data = Data;
        }
        
        [ReportField(F.Sequence)]
        public readonly int Sequence;

        [ReportField(F.Address)]
        public readonly MemoryAddress Address;

        [ReportField(F.Length)]
        public readonly int Length;

        [ReportField(F.Uri)]
        public readonly OpUri Uri;
        
        [ReportField(F.OpSig)]
        public readonly string OpSig;

        [ReportField(F.Data)]
        public readonly EncodedData Data;

        public string DelimitedText(char sep)
        {
            var dst = Model.Formatter.Reset();            
            dst.AppendField(F.Sequence, Sequence);
            dst.DelimitField(F.Address, Address, sep);
            dst.DelimitField(F.Length, Length, sep);
            dst.DelimitField(F.Uri, Uri, sep);
            dst.DelimitField(F.OpSig, OpSig, sep);
            dst.DelimitField(F.Data, Data, sep);
            return dst.Format();            
        }

        static Report<F,R> Model => Report<F,R>.Empty;
    }

    public class CapturedEncodingReport : Report<F,R>
    {        
        public static CapturedEncodingReport Create(CapturedEncodingRecord[] records)
            => new CapturedEncodingReport(records);
        
        CapturedEncodingReport(CapturedEncodingRecord[] records)
            : base(records)
        {
        }        
    }    
}