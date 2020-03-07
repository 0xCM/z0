//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using F = MemberExtractField;
    using R = MemberExtractRecord;
    using Report = MemberExtractReport;
    using Created = ExtractReportCreated;

    public enum MemberExtractField : ulong
    {
        Sequence = 0 | 10ul << 32,

        Address = 1 | 16ul << 32,

        Length = 2 | 8ul << 32,

        Uri = 3 | 110ul << 32,

        OpSig = 4 | 110ul << 32,

        Data = 5 | 1ul << 32
    }

    public readonly struct MemberExtractRecord : IRecord<F, R>
    {
        public MemberExtractRecord(int Sequence, MemoryAddress Address, int Length, OpUri Uri, string OpSig, MemoryExtract Data)
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
        public readonly MemoryExtract Data;

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
    
    public class MemberExtractReport : Report<MemberExtractReport,F,R>
    {        
        public ApiHostUri ApiHost {get;}

        public override string ReportName => $"Extract report for {ApiHost.Format()}";

        public static MemberExtractReport Create(ApiHostUri host, MemberExtract[] extracts)
        {
            var records = new MemberExtractRecord[extracts.Length];
            for(var i=0; i< extracts.Length; i++)
            {
                var op = extracts[i];
                records[i] = new MemberExtractRecord(                
                    Sequence : i,
                    Address : op.Member.Address,
                    Length : op.EncodedData.Length,
                    Uri : op.Uri,
                    OpSig : op.Member.Member.Signature().Format(),
                    Data : op.EncodedData
                    );

            }
            return new MemberExtractReport(host, records);
        }
        
        public MemberExtractReport(){}

        MemberExtractReport(ApiHostUri host, MemberExtractRecord[] records)
            : base(records)
        {
            this.ApiHost = host;
        }        
        
        public Created CreatedEvent()
            => Created.Define(this);
    }    

    public readonly struct ExtractReportCreated : IAppEvent<Created,Report>
    {
        public static Created Empty => new ExtractReportCreated(Report.Empty);
        
        [MethodImpl(Inline)]
        public static Created Define(Report report)
            => new Created(report);

        [MethodImpl(Inline)]
        public ExtractReportCreated(Report report)
        {
            this.EventData = report;
        }

        public Report EventData {get;}

        public string EventName
            => $"{EventData.ReportName} created: {EventData.RecordCount}";
        
        public string Format()
            => EventName;         
    }    
}