//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using F = CapturedEncodingField;
    using R = CapturedEncodingRecord;

    public enum CapturedEncodingField
    {
        Sequence = 10,

        Address = 16,

        Length = 8,

        Uri = 110,

        OpSig = 110,

        Data = 1
    }

    public class CapturedEncodingRecord : IRecord<F, R>
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
        public int Sequence {get;}

        [ReportField(F.Address)]
        public MemoryAddress Address {get;}

        [ReportField(F.Length)]
        public int Length {get;}

        [ReportField(F.Uri)]
        public OpUri Uri {get;}
        
        [ReportField(F.OpSig)]
        public string OpSig {get;}

        [ReportField(F.Data)]
        public EncodedData Data {get;}

        public string DelimitedText(char sep)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Sequence, F.Sequence);
            dst.DelimitField(Address, F.Address, sep); 
            dst.DelimitField(Length, F.Length, sep);
            dst.DelimitField(Uri, F.Uri, sep);
            dst.DelimitField(OpSig, F.OpSig, sep);
            dst.DelimitField(Data, F.Data, sep);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Reports.ReportHeaders(GetType());
    }

    public readonly struct CapturedEncodingReport : IReport<CapturedEncodingRecord>
    {
        public static CapturedEncodingReport Create(ApiHost src, CapturedEncodingRecord[] records)
            => new CapturedEncodingReport(src,records);

        CapturedEncodingReport(ApiHost src, CapturedEncodingRecord[] records)
        {
            this.Source = src;
            this.Records = records;
        }
        
        public ApiHost Source {get;}

        public CapturedEncodingRecord[] Records {get;}

        public Option<FilePath> Save(FilePath dst)
            => Records.Save(dst); 

        public CapturedEncodingRecord this[int index]
            => Records[index];                

        public int RecordCount
            => Records.Length;
    }    
}