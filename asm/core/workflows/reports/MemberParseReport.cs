//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using F = AsmWorkflowReports.MemberParseField;
    using R = AsmWorkflowReports.MemberParseRecord;
    using Report = AsmWorkflowReports.MemberParseReport;
    using Created = AsmWorkflowReports.ParseReportCreated;

    partial class AsmWorkflowReports
    {
        public enum MemberParseField : ulong
        {
            Seq = 0 | 12ul << 32,

            SourceSeq = 1 | 12ul << 32,

            Address = 2 | 16ul << 32,

            Length = 3 | 8ul << 32,

            TermCode = 4 | 20ul << 32,

            Uri = 5 | 110ul << 32,

            OpSig = 6 | 110ul << 32,

            Data = 6 | 1ul << 32
        }    

        public readonly struct MemberParseRecord : IRecord<F, R>
        {                        
            public static MemberParseRecord Empty => Define(0, 0, MemoryAddress.Zero, 0, ExtractTermCode.None, OpUri.Empty, text.blank, MemoryExtract.Empty);
            
            public static implicit operator ParsedOpExtract(MemberParseRecord src)
                => src.ToParsedEncoding();

            public static R From(in ParsedExtract extract, int seq)
                => MemberParseRecord.Define
                    (
                        Sequence : seq,
                        SourceSequence: extract.SourceSequence,
                        Address : extract.Address,
                        Length : extract.ParsedContent.Length,
                        TermCode: extract.TermCode,
                        Uri : extract.Uri,
                        OpSig : extract.SourceMember.Signature().Format(),
                        Data : extract.ParsedContent
                    );

            public static MemberParseRecord Define(int Sequence, int SourceSequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, MemoryExtract Data)
                => new MemberParseRecord(Sequence, SourceSequence, Address, Length, TermCode, Uri,OpSig,Data);
            
            MemberParseRecord(int Sequence, int SourceSequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, MemoryExtract Data)
            {
                this.Seq = Sequence;
                this.SourceSeq = SourceSequence;                
                this.Address = Address;
                this.Length = Length; 
                this.TermCode = TermCode;
                this.Uri = Uri;
                this.OpSig = OpSig;
                this.Data = Data;
            }
            
            [ReportField(F.Seq)]
            public int Seq {get;}

            [ReportField(F.SourceSeq)]
            public int SourceSeq {get;}

            [ReportField(F.Address)]
            public MemoryAddress Address {get; }

            [ReportField(F.Length)]
            public int Length {get; }

            [ReportField(F.TermCode)]
            public ExtractTermCode TermCode {get; }

            [ReportField(F.Uri)]
            public OpUri Uri {get;}

            [ReportField(F.OpSig)]
            public string OpSig {get; }

            [ReportField(F.Data)]
            public MemoryExtract Data {get; }

            public dynamic this[F f]
            {
                get => f switch {
                    F.Seq => Seq,
                    F.SourceSeq => SourceSeq,
                    F.Address => Address,
                    F.Length => Length,
                    F.TermCode => TermCode,
                    F.Uri => Uri,
                    F.OpSig => OpSig,
                    F.Data => Data,
                    _ => 0,
                };
            }

            public string DelimitedText(char sep)
            {
                var dst = Model.Formatter.Reset();            
                dst.AppendField(F.Seq, Seq);
                dst.DelimitField(F.SourceSeq, SourceSeq, sep);
                dst.DelimitField(F.Address, Address, sep);
                dst.DelimitField(F.Length, Length, sep);
                dst.DelimitField(F.TermCode, TermCode, sep);
                dst.DelimitField(F.Uri, Uri, sep);
                dst.DelimitField(F.OpSig, OpSig, sep);
                dst.DelimitField(F.Data, Data, sep);
                return dst.Format();            
            }

            static Report<F,R> Model => Report<F,R>.Empty;

            /// <summary>
            /// Gets the parsed encoding described by the source record
            /// </summary>
            /// <param name="src">The source record</param>
            public ParsedOpExtract ToParsedEncoding()
            {
                var src = this;
                var count = src.Length;
                var op = MemberDescriptor.Define(src.Uri, src.OpSig);
                var range = MemoryRange.Define(src.Address, src.Address + (MemoryAddress)count);
                var final = ExtractionState.Define(op.Id, count, range.End, src.Data.LastByte);
                var outcome = ExtractionOutcome.Define(final, range, src.TermCode);
                return ParsedOpExtract.Define(op, outcome.TermCode, src.Data);
            }
        }

        public class MemberParseReport : Report<Report,F,R>
        {             
            public ApiHostUri ApiHost {get;}

            [MethodImpl(Inline)]
            public static Report Create(ApiHostUri host, params R[] records)
                => new Report(records);

            public static Report Create(ApiHostUri host, ParsedExtract[] extracts)
            {
                var records = new MemberParseRecord[extracts.Length];
                for(var i=0; i< records.Length; i++)
                {
                    ref readonly var extract = ref extracts[i];
                    records[i] = R.From(extract, i);
                    
                }
                return new Report(records);
            }

            public MemberParseReport(){}
            
            [MethodImpl(Inline)]
            MemberParseReport(params R[] records)
                : base(records)
            {

            }

            public Created CreatedEvent()
                => Created.Define(this);
        }

        public readonly struct ParseReportCreated : IAppEvent<Created,Report>
        {
            public static Created Empty => new Created(MemberParseReport.Empty);

            [MethodImpl(Inline)]
            public static Created Define(Report report)
                => new Created(report);

            [MethodImpl(Inline)]
            ParseReportCreated(Report report)
            {
                this.EventData = report;
            }

            public Report EventData {get;}

            public string Description
                => $"{EventData.RecordCount} records created for {EventData.ReportName}";
            
            public string Format()
                => Description;         
        }    
    }
}