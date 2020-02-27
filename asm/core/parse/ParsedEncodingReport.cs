//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using F = ParsedEncodingField;
    using R = ParsedEncodingRecord;

    public enum ParsedEncodingField
    {
        Sequence = 10,

        Address = 16,

        Length = 8,

        TermCode = 20,

        Uri = 110,

        OpSig = 110,

        Data = 1
    }    

    public class ParsedEncodingRecord : IRecord<F, R>
    {        
        public ParsedEncodingRecord(int Sequence, MemoryAddress Address, int Length, CaptureTermCode TermCode, OpUri Uri, string OpSig, EncodedData Data)
        {
            this.Sequence = Sequence;
            this.Address = Address;
            this.Length = Length; 
            this.TermCode = TermCode;
            this.Uri = Uri;
            this.OpSig = OpSig;
            this.Data = Data;
        }

        [ReportField(F.Sequence)]
        public int Sequence {get;}

        [ReportField(F.Address)]
        public MemoryAddress Address {get; }

        [ReportField(F.Length)]
        public int Length {get; }

        [ReportField(F.TermCode)]
        public CaptureTermCode TermCode {get; }

        [ReportField(F.Uri)]
        public OpUri Uri {get;}

        [ReportField(F.OpSig)]
        public string OpSig {get; }

        [ReportField(F.Data)]
        public EncodedData Data {get; }

        public string DelimitedText(char sep)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Sequence, F.Sequence);
            dst.DelimitField(Address, F.Address, sep); 
            dst.DelimitField(Length, F.Length,sep); 
            dst.DelimitField(TermCode, F.TermCode, sep);
            dst.DelimitField(Uri, F.Uri, sep);
            dst.DelimitField(OpSig, F.OpSig, sep);
            dst.DelimitField(Data, F.Data, sep);
            return dst.ToString();
        }



    }

    public interface ParsedEncodingReport : IReport<F,R> { }


 
}