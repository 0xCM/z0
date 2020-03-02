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

    public readonly struct ExtractionReportParser : IExtractionReportParser
    {
        public IAsmContext Context {get;}

        byte[] PatternBuffer {get;}

        [MethodImpl(Inline)]
        public static IExtractionReportParser Create(IAsmContext context, byte[] buffer)
            => new ExtractionReportParser(context,buffer);

        [MethodImpl(Inline)]
        ExtractionReportParser(IAsmContext context, byte[] buffer)
        {
            Context = context;
            PatternBuffer = buffer;
        }

        public ParsedEncodingReport Parse(ApiHost host, ExtractionReport encoded)
        {
            var dst = new ParsedEncodingRecord[encoded.Records.Length];
            //var parser = ExtractionReportParser.ByteParser(Context, BufferLength);
            var parser = Context.PatternParser(PatternBuffer.Clear());            
            Context.PostMessage($"Parsing {encoded.Records.Length} {host} records");

            for(var i=0; i< dst.Length; i++)
            {
                var current = encoded.Records[i];
                var status = parser.Parse(current.Data);
                
                var matched = parser.Result;
                var succeeded = matched.IsSome() && status.Success();
                
                // if(!succeeded)
                //     print($"Parse failure: {matched}, {current.Uri}", AppMsgKind.Warning);

                var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
                dst[i] = ParsedEncodingRecord.Define
                (
                     Sequence : current.Sequence,
                     Address : current.Address,
                     Length : data.Length,
                     TermCode: matched.ToTermCode(),
                     Uri : OpUri.Hex(host.Path, current.Uri.GroupName, current.Uri.OpId),
                     OpSig : current.OpSig,
                     Data : EncodedData.Define(current.Address, data)
                );
            }

            ReportDuplicates(dst.Select(x => x.Uri.OpId).Duplicates());

            return AsmReports.ParsedEncodings(host.Path, dst);
        }

        // static ByteParser<EncodingPatternKind> ByteParser(IAsmContext context, int size)
        //     => ByteParser<EncodingPatternKind>.Create(context, EncodingPatterns.Default, size);

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