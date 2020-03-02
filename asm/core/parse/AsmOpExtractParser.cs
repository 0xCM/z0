//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    public readonly struct AsmOpExtractParser : IAsmOpExtractParser
    {
        public IAsmContext Context {get;}

        byte[] PatternBuffer {get;}

        [MethodImpl(Inline)]
        public static IAsmOpExtractParser Create(IAsmContext context, byte[] buffer)
            => new AsmOpExtractParser(context,buffer);

        [MethodImpl(Inline)]
        AsmOpExtractParser(IAsmContext context, byte[] buffer)
        {
            Context = context;
            PatternBuffer = buffer;
        }

        static Option<AsmParseRecord> Parse(in ByteParser<EncodingPatternKind> parser, in AsmOpExtractRecord src)
        {
            var status = parser.Parse(src.Data);
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();                
            if(succeeded)
            {
                var data = parser.Parsed.ToArray();
                return AsmParseRecord.Define
                (
                     Sequence : src.Sequence,
                     Address : src.Address,
                     Length : data.Length,
                     TermCode: matched.ToTermCode(),
                     Uri : OpUri.Hex(src.Uri.HostPath, src.Uri.GroupName, src.Uri.OpId),
                     OpSig : src.OpSig,
                     Data : EncodedData.Define(src.Address, data)
                );
            }
            else 
                return none<AsmParseRecord>();
        }

        public AsmParseReport Parse(ApiHost host, AsmOpExtractReport encoded)
        {
            var dst = new AsmParseRecord[encoded.Records.Length];
            var parser = Context.PatternParser(PatternBuffer.Clear());            
            Context.PostMessage($"Parsing {encoded.Records.Length} {host} records");

            for(var i=0; i< dst.Length; i++)
            {
                var current = encoded.Records[i];
                var parsed = Parse(parser,current);
                dst[i] = parsed.ValueOrElse(() => AsmParseRecord.Empty);
                
                // var status = parser.Parse(current.Data);                
                // var matched = parser.Result;
                // var succeeded = matched.IsSome() && status.Success();                
                // var data = succeeded ? parser.Parsed.ToArray() : array<byte>();

                // dst[i] = AsmParseRecord.Define
                // (
                //      Sequence : current.Sequence,
                //      Address : current.Address,
                //      Length : data.Length,
                //      TermCode: matched.ToTermCode(),
                //      Uri : OpUri.Hex(host.Path, current.Uri.GroupName, current.Uri.OpId),
                //      OpSig : current.OpSig,
                //      Data : EncodedData.Define(current.Address, data)
                // );
            }

            ReportDuplicates(dst.Select(x => x.Uri.OpId).Duplicates());

            return AsmReports.ParsedEncodings(host.Path, dst);
        }

        void ReportDuplicates(OpIdentity[] duplicated)
        {
            if(duplicated.Length != 0)
            {
                var format = string.Join(text.comma(), duplicated);
                Context.PostMessage($"Identifier duplicates: {format}", AppMsgKind.Warning);           
            }
        }
    }
}