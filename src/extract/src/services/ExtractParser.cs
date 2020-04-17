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

    using Asm;
    
    using ByteParser = ByteParser<EncodingPatternKind>;

    readonly struct ExtractParser : IExtractParser
    {
        readonly IContext Context;

        //readonly IAppMsgSink MsgSink;

        byte[] PatternBuffer {get;}

        [MethodImpl(Inline)]
        public static IExtractParser Create(IContext context, byte[] buffer)
            => new ExtractParser(context,buffer);

        [MethodImpl(Inline)]
        public static IExtractParser Create(IContext context, int? bufferlen = null)
            => new ExtractParser(context, new byte[bufferlen ?? Pow2.T14]);

        [MethodImpl(Inline)]
        ExtractParser(IContext context, byte[] buffer)
        {
            //MsgSink = context;
            Context = context;
            PatternBuffer = buffer;
        }

        public Option<ParsedExtract> Parse(in ApiMemberExtract src, int seq = 0)
            => Parse(src, seq, Parser());

        public ParsedExtract[] Parse(ApiMemberExtract[] extracts)
        {
            var dst = list<ParsedExtract>(extracts.Length);
            var parser = Parser();
            for(var i=0; i< extracts.Length; i++)
            {
                ref readonly var extract = ref extracts[i];                
                var parsed = Parse(extract, i, parser);
                parsed.OnSome(x => dst.Add(x));
            }

            return dst.ToArray();
        }

        ByteParser Parser() => Context.PatternParser(PatternBuffer.Clear());

        Option<ParsedExtract> Parse(in ApiMemberExtract src, int seq, ByteParser parser)
        {
            var status = parser.Parse(src.EncodedData);                
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success(); 
            var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
            return succeeded 
                ? ParsedExtract.Define(src, seq, matched.ToTermCode(), Addressable.Define(src.EncodedData.Address, data))
                : none<ParsedExtract>();
        }

        public MemberParseReport Parse(IApiHost host, ApiExtractReport extracts)
        {
            var records = list<MemberParseRecord>(extracts.RecordCount);
            var parser = Context.PatternParser(PatternBuffer.Clear());            
            //MsgSink.Notify($"Parsing {extracts.Records.Length} {host} records");
            
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
                    var data = Addressable.Define(extract.Address, bytes);
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