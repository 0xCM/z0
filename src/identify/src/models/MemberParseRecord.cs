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

    public readonly struct MemberParseRecord : ITabular<F,R>
    {                                
        public static MemberParseRecord Empty 
            => Define(0, 0, MemoryAddress.Zero, 0, ExtractTermCode.None, OpUri.Empty, text.blank, LocatedCode.Empty);
        
        public static R From(in ParsedMember extract, int seq)
            => MemberParseRecord.Define
                (
                    Sequence : seq,
                    SourceSequence: extract.Sequence,
                    Address : extract.Address,
                    Length : extract.Encoded.Length,
                    TermCode: extract.TermCode,
                    Uri : extract.Uri,
                    OpSig : extract.Method.Signature().Format(),
                    Data : extract.Encoded
                );

        public static MemberParseRecord Define(int Sequence, int SourceSequence, MemoryAddress Address, 
            int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, LocatedCode Data)
                => new MemberParseRecord(Sequence, SourceSequence, Address, Length, TermCode, Uri,OpSig,Data);
        
        internal MemberParseRecord(int Sequence, int SourceSequence, MemoryAddress Address, 
            int Length, ExtractTermCode TermCode, OpUri Uri, string OpSig, LocatedCode Data)
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
        
        [TabularField(F.Seq)]
        public int Seq {get;}

        [TabularField(F.SourceSeq)]
        public int SourceSeq {get;}

        [TabularField(F.Address)]
        public MemoryAddress Address {get; }

        [TabularField(F.Length)]
        public int Length {get; }

        [TabularField(F.TermCode)]
        public ExtractTermCode TermCode {get; }

        [TabularField(F.Uri)]
        public OpUri Uri {get;}

        [TabularField(F.OpSig)]
        public string OpSig {get; }

        [TabularField(F.Data)]
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