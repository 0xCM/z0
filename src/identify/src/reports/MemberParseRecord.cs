//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using F = MemberParseField;
    using R = MemberParseRecord;

    public enum MemberParseField : uint
    {
        Seq = 0 | 12 << 16,

        SourceSeq = 1 | 12 << 16,

        Address = 2 | 16 << 16,

        Length = 3 | 8 << 16,

        TermCode = 4 | 20 << 16,

        Uri = 5 | 110 << 16,

        OpSig = 6 | 110 << 16,

        Data = 7 | 1 << 16
    }    

    public readonly struct MemberParseRecord : ITabular<F,R>
    {                                
        public const int FieldCount = 8;

        public static R Empty 
            => new R(0, 0, MemoryAddress.Empty, 0, ExtractTermCode.None, OpUri.Empty, text.blank, LocatedCode.Empty);

        public static ParseResult<MemberParseRecord> Parse(string src)
        {
            try
            {
                var fields = src.SplitClean(Tabular.DefaultDelimiter);
                if(fields.Length !=  (uint)FieldCount)
                    return ParseResult.Fail<MemberParseRecord>(src,"No data");

                var index = 0;

                var numericParser = NumericParser.infallible<int>();
                var addressParser = Parsers.address();
                var dataParser = Parsers.hex(true);

                var seq = numericParser.Parse(fields[index++]);
                var srcSeq = numericParser.Parse(fields[index++]);
                var address = addressParser.Parse(fields[index++], MemoryAddress.Empty);
                var len = numericParser.Parse(fields[index++]);
                var term = Enums.Parse(fields[index++], ExtractTermCode.None);
                var uri = OpUri.ParseDefault(fields[index++]);
                var sig = fields[index++];
                var data = LocatedCode.Define(address, dataParser.ParseData(fields[index++], Control.array<byte>()));  
                          
                return ParseResult.Success(src, new R(
                    Seq: seq, 
                    SourceSequence: srcSeq, 
                    Address: address, 
                    Length: len, 
                    TermCode: default,
                    Uri:uri, 
                    OpSig:sig, 
                    Data:data
                    ));
            }
            catch(Exception e)
            {   
                return ParseResult.Fail<MemberParseRecord>(src, e);
            }
        }

        public static R From(in ParsedMember extract, int seq)
            => new R
                (
                    Seq : seq,
                    SourceSequence: extract.Sequence,
                    Address : extract.Address,
                    Length : extract.Encoded.Length,
                    TermCode: extract.TermCode,
                    Uri : extract.OpUri,
                    OpSig : extract.Method.Signature().Format(),
                    Data : extract.Encoded
                );

        public MemberParseRecord(
            int Seq, 
            int SourceSequence, 
            MemoryAddress Address, 
            int Length, 
            ExtractTermCode TermCode, 
            OpUri Uri, 
            string OpSig, 
            LocatedCode Data
            )
        {
            this.Seq = Seq;
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

        public string DelimitedText(char delimiter)
        {
            var dst = Tabular.formatter<F>(delimiter);            
            dst.Append(F.Seq, Seq);
            dst.Delimit(F.SourceSeq, SourceSeq);
            dst.Delimit(F.Address, Address);
            dst.Delimit(F.Length, Length);
            dst.Delimit(F.TermCode, TermCode);
            dst.Delimit(F.Uri, Uri);
            dst.Delimit(F.OpSig, OpSig);
            dst.Delimit(F.Data, Data.Format());
            return dst.Format();            
        }        
    }
}