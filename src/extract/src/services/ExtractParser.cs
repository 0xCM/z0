//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Seed;
    using static Memories;
    
    using BP = ByteParser<EncodingPatternKind>;

    readonly struct ExtractParser : IExtractParser
    {
        byte[] PatternBuffer {get;}

        [MethodImpl(Inline)]
        internal ExtractParser(byte[] buffer)
        {
            PatternBuffer = buffer;
        }

        public Option<ParsedMember> Parse(in MemberExtract src, int seq = 0)
            => Parse(src, seq, Parser());

        public ParsedMember[] Parse(MemberExtract[] extracts)
        {
            var dst = list<ParsedMember>(extracts.Length);
            var parser = Parser();
            for(var i=0; i< extracts.Length; i++)
            {
                ref readonly var extract = ref extracts[i];                
                var parsed = Parse(extract, i, parser);
                parsed.OnSome(x => dst.Add(x));
            }

            return dst.ToArray();
        }

        BP Parser() 
            => Extract.Services.PatternParser(PatternBuffer.Clear());

        Option<ParsedMember> Parse(in MemberExtract src, int seq, BP parser)
        {
            var status = parser.Parse(src.Content);                
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success(); 
            var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
            return succeeded 
                ? ParsedMember.Define(src, seq, matched.ToTermCode(), LocatedCode.Define(src.Content.Address, data))
                : none<ParsedMember>();
        }

        public MemberParseReport Parse(IApiHost host, ExtractReport extracts)
        {
            var records = list<MemberParseRecord>(extracts.RecordCount);
            var parser = Extract.Services.PatternParser(PatternBuffer.Clear());
            
            var seq = 0;
            for(var i=0; i< extracts.RecordCount; i++)
            {
                ref readonly var extract = ref extracts.Records[i];                
                var status = parser.Parse(extract.Data);                
                var matched = parser.Result;
                if(matched.IsSome() && status.Success())
                {
                    var bytes = parser.Parsed.ToArray();
                    var uri = OpUri.hex(host.UriPath, extract.Uri.GroupName, extract.Uri.OpId);
                    var data = LocatedCode.Define(extract.Address, bytes);
                    var record = MemberParseRecord.Define
                    (
                        Sequence: seq++,
                        SourceSequence: extract.Sequence,
                        Address: extract.Address,
                        Length: bytes.Length,
                        TermCode: matched.ToTermCode(),
                        Uri: uri,
                        OpSig: extract.OpSig,
                        Data: data
                    );
                    records.Add(record);               
                }
            }

            ReportDuplicates(Identify.duplicates(records.Select(x => x.Uri.OpId)));
            return MemberParseReport.Create(host.UriPath, records.ToArray());
        }

        void ReportDuplicates(OpIdentity[] duplicated)
        {
            if(duplicated.Length != 0)
            {
                var format = string.Join(text.comma(), duplicated);
                //MsgSink.Notify($"Identifier duplicates: {format}", AppMsgKind.Warning);           
            }
        }
    }
}