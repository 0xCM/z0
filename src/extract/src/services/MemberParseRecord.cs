//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using F = MemberParseField;
    using R = MemberParseRecord;

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
        /// <summary>
        /// Gets the parsed encoding described by the source record
        /// </summary>
        /// <param name="src">The source record</param>
        public static ParsedMember ToParsedEncoding(MemberParseRecord src)
        {
            var count = src.Length;
            var range = MemoryRange.Define(src.Address, src.Address + (MemoryAddress)count);
            var final = ExtractState.Define(src.Uri.OpId, count, range.End, src.Data.LastByte);
            var outcome = CaptureOutcome.Define(final, range, src.TermCode);
            return ParsedMember.Define(src.Uri, src.OpSig, outcome.TermCode, src.Data);
        }        
        
        public static MemberParseRecord Empty => Define(0, 0, MemoryAddress.Zero, 0, ExtractTermCode.None, OpUri.Empty, text.blank, LocatedCode.Empty);
        
        public static R From(in ParsedMemberExtract extract, int seq)
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

        public static MemberParseRecord Define(int Sequence, int SourceSequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, LocatedCode Data)
            => new MemberParseRecord(Sequence, SourceSequence, Address, Length, TermCode, Uri,OpSig,Data);
        
        MemberParseRecord(int Sequence, int SourceSequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, LocatedCode Data)
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
        public LocatedCode Data {get; }

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
            dst.DelimitField(F.Data, Data.Format(), sep);
            return dst.Format();            
        }

        static Report<F,R> Model => Report<F,R>.Empty;
    }
}