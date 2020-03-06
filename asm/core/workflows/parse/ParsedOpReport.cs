//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using F = ParsedOpField;
    using R = ParsedOpRecord;

    public enum ParsedOpField : ulong
    {
        Sequence = 0 | 10ul << 32,

        Address = 1 | 16ul << 32,

        Length = 2 | 8ul << 32,

        TermCode = 3 | 20ul << 32,

        Uri = 4 | 110ul << 32,

        OpSig = 5 | 110ul << 32,

        Data = 6 | 1ul << 32
    }    

    public readonly struct ParsedOpRecord : IRecord<F, R>
    {                        
        public static ParsedOpRecord Empty => Define(0, MemoryAddress.Zero, 0, ExtractTermCode.None, OpUri.Empty, text.blank, MemoryExtract.Empty);
        
        public static implicit operator ParsedOpExtract(ParsedOpRecord src)
            => src.ToParsedEncoding();

        public static ParsedOpRecord Define(int Sequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, MemoryExtract Data)
            => new ParsedOpRecord(Sequence, Address, Length, TermCode, Uri,OpSig,Data);
        
        ParsedOpRecord(int Sequence, MemoryAddress Address, int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, MemoryExtract Data)
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
        public ParsedOpExtract ToParsedEncoding()
        {
            var src = this;
            var count = src.Length;
            var op = OpDescriptor.Define(src.Uri, src.OpSig);
            var range = MemoryRange.Define(src.Address, src.Address + (MemoryAddress)count);
            var final = OpExtractionState.Define(op.Id, count, range.End, src.Data.LastByte);
            var outcome = ExtractionOutcome.Define(final, range, src.TermCode);
            return ParsedOpExtract.Define(op, outcome.TermCode, src.Data);
        }
    }

    public class ParsedOpReport : Report<ParsedOpReport,F,R>
    {             
        [MethodImpl(Inline)]
        public static ParsedOpReport Create(params ParsedOpRecord[] records)
            => new ParsedOpReport(records);

        public ParsedOpReport(){}
        
        [MethodImpl(Inline)]
        ParsedOpReport(params ParsedOpRecord[] records)
            : base(records)
        {

        }
    }
}