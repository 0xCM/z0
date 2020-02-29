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

    using static Root;

    using F = ParsedEncodingField;
    using R = ParsedEncodingRecord;

    public enum ParsedEncodingField : ulong
    {
        Sequence = 0 | 10ul << 32,

        Address = 1 | 16ul << 32,

        Length = 2 | 8ul << 32,

        TermCode = 3 | 20ul << 32,

        Uri = 4 | 110ul << 32,

        OpSig = 5 | 110ul << 32,

        Data = 6 | 1ul << 32
    }    

    public readonly struct ParsedEncodingRecord : IRecord<F, R>
    {        
        public static implicit operator ParsedEncoding(ParsedEncodingRecord src)
            => src.ToParsedEncoding();

        public static ParsedEncodingRecord Define(int Sequence, MemoryAddress Address, int Length, CaptureTermCode TermCode, OpUri Uri, string OpSig, EncodedData Data)
            => new ParsedEncodingRecord(Sequence, Address, Length, TermCode, Uri,OpSig,Data);
        
        ParsedEncodingRecord(int Sequence, MemoryAddress Address, int Length, CaptureTermCode TermCode, OpUri Uri, string OpSig, EncodedData Data)
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

        public dynamic this[F f]
        {
            get => f switch {
                F.Sequence => Sequence,
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
            dst.AppendField(F.Sequence, Sequence);
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
        public ParsedEncoding ToParsedEncoding()
        {
            var src = this;
            var count = src.Length;
            var op = OpDescriptor.Define(src.Uri, src.OpSig);
            var range = MemoryRange.Define(src.Address, src.Address + (MemoryAddress)count);
            var final = CaptureState.Define(op.Id, count, range.End, src.Data.LastByte);
            var outcome = CaptureOutcome.Define(final, range, src.TermCode);
            return ParsedEncoding.Define(op, outcome.TermCode, src.Data);
        }
    }

    public class ParsedEncodingReport : Report<ParsedEncodingReport,F,R>
    {             
        [MethodImpl(Inline)]
        public static ParsedEncodingReport Create(params ParsedEncodingRecord[] records)
            => new ParsedEncodingReport(records);

        public ParsedEncodingReport(){}
        
        [MethodImpl(Inline)]
        ParsedEncodingReport(params ParsedEncodingRecord[] records)
            : base(records)
        {

        }
    }
}