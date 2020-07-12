//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

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

    public readonly struct MemberParseRecord : ITabular<F,R>, ISequential
    {                                
        public readonly int Seq;

        public readonly int SourceSeq;

        public readonly MemoryAddress Address;

        public readonly int Length;

        public readonly ExtractTermCode TermCode;

        public readonly OpUri Uri;

        public readonly string OpSig;

        public readonly LocatedCode Data;

        public const int FieldCount = 8;

        int ISequential.Sequence 
            => Seq;

        public static R Empty 
            => new R(0, 0, 0, 0, 0, OpUri.Empty, EmptyString, LocatedCode.Empty);

        public static ParseResult<MemberParseRecord> Parse(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)FieldCount)
                    return ParseResult.Fail<MemberParseRecord>(src,"No data");

                var index = 0;

                var numericParser = NumericParser.infallible<int>();
                var addressParser = MemoryAddressParser.Service;
                var dataParser = Parsers.hex(true);

                var seq = numericParser.Parse(fields[index++]);
                var srcSeq = numericParser.Parse(fields[index++]);
                var address = addressParser.Parse(fields[index++], MemoryAddress.Empty);
                var len = numericParser.Parse(fields[index++]);
                var term = Enums.Parse(fields[index++], ExtractTermCode.None);
                var uri = OpUriParser.Service.Parse(fields[index++]);
                if(uri.Failed)
                    sys.@throw(uri.Reason);
                var sig = fields[index++];
                var data = new LocatedCode(address, dataParser.ParseData(fields[index++], Array.Empty<byte>()));  
                          
                return ParseResult.Success(src, new R(
                    Seq: seq, 
                    SourceSequence: srcSeq, 
                    Address: address, 
                    Length: len, 
                    TermCode: default,
                    Uri:uri.Value, 
                    OpSig:sig, 
                    Data:data
                    ));
            }
            catch(Exception e)
            {   
                return ParseResult.Fail<MemberParseRecord>(src, e);
            }
        }

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
            var dst = DataFields.formatter<F>(delimiter);            
            dst.Delimit(F.Seq, Seq);
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