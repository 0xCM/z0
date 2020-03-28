//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static root;
    using static AsmWorkflowReports;
    using static AsmServiceMessages;

    public readonly struct OpExtractParser : IOpExtractParser
    {
        public IAsmContext Context {get;}

        byte[] PatternBuffer {get;}

        [MethodImpl(Inline)]
        public static IOpExtractParser New(IAsmContext context, byte[] buffer)
            => new OpExtractParser(context,buffer);

        [MethodImpl(Inline)]
        public static IOpExtractParser New(IAsmContext context, int? bufferlen = null)
            => new OpExtractParser(context, new byte[bufferlen ?? context.DefaultBufferLength]);

        [MethodImpl(Inline)]
        OpExtractParser(IAsmContext context, byte[] buffer)
        {
            Context = context;
            PatternBuffer = buffer;
        }


        Option<ParsedExtract> Parse(in MemberExtract src, int seq, ByteParser<EncodingPatternKind> parser)
        {
            var status = parser.Parse(src.EncodedData);                
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success(); 
            // if(!succeeded)               
            //     Context.NotifyConsole(ExtractParseFailure(src.Uri, matched.ToTermCode()));
            var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
            return succeeded 
                ? ParsedExtract.Define(src, seq, matched.ToTermCode(), MemoryExtract.Define(src.EncodedData.Address, data))
                : none<ParsedExtract>();
        }

        public ParsedExtract[] Parse(MemberExtract[] extracts)
        {
            var dst = list<ParsedExtract>(extracts.Length);
            var parser = Context.PatternParser(PatternBuffer.Clear());               
            for(var i=0; i< extracts.Length; i++)
            {
                ref readonly var extract = ref extracts[i];                
                var parsed = Parse(extract, i, parser);
                parsed.OnSome(x => dst.Add(x));
            }

            return dst.ToArray();
        }

        public MemberParseReport Parse(ApiHost host, MemberExtractReport extracts)
        {
            var records = list<MemberParseRecord>(extracts.RecordCount);
            var parser = Context.PatternParser(PatternBuffer.Clear());            
            Context.Notify($"Parsing {extracts.Records.Length} {host} records");
            
            var seq = 0;
            for(var i=0; i< extracts.RecordCount; i++)
            {
                ref readonly var extract = ref extracts.Records[i];                
                var status = parser.Parse(extract.Data);                
                var matched = parser.Result;
                if(matched.IsSome() && status.Success())
                {
                    var bytes = parser.Parsed.ToArray();
                    var uri = OpUri.hex(host.Path, extract.Uri.GroupName, extract.Uri.OpId);
                    var data = MemoryExtract.Define(extract.Address, bytes);
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

            ReportDuplicates(Identify.Duplicates(records.Select(x => x.Uri.OpId)));
            return MemberParseReport.Create(host, records.ToArray());
        }

        void ReportDuplicates(OpIdentity[] duplicated)
        {
            if(duplicated.Length != 0)
            {
                var format = string.Join(text.comma(), duplicated);
                Context.Notify($"Identifier duplicates: {format}", AppMsgKind.Warning);           
            }
        }
    }
}