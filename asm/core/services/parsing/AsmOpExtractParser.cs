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

        static AsmParseRecord Parse(in ByteParser<EncodingPatternKind> parser, in AsmOpExtractRecord current)
        {
            var status = parser.Parse(current.Data);                
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();                
            var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
            return AsmParseRecord.Define
            (
                Sequence : current.Sequence,
                Address : current.Address,
                Length : data.Length,
                TermCode: matched.ToTermCode(),
                Uri : OpUri.Hex(current.Uri.HostPath, current.Uri.GroupName, current.Uri.OpId),
                OpSig : current.OpSig,
                Data : MemoryEncoding.Define(current.Address, data)
            );
        }

        public AsmParseReport Parse(ApiHost host, AsmOpExtractReport encoded)
        {
            var dst = new AsmParseRecord[encoded.Records.Length];
            var parser = Context.PatternParser(PatternBuffer.Clear());            
            Context.Enqueue($"Parsing {encoded.Records.Length} {host} records");

            for(var i=0; i< dst.Length; i++)
            {
                ref readonly var current = ref encoded.Records[i];                
                var status = parser.Parse(current.Data);                
                var matched = parser.Result;
                var succeeded = matched.IsSome() && status.Success();                
                var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
                dst[i] = AsmParseRecord.Define
                (
                     Sequence : current.Sequence,
                     Address : current.Address,
                     Length : data.Length,
                     TermCode: matched.ToTermCode(),
                     Uri : OpUri.Hex(host.Path, current.Uri.GroupName, current.Uri.OpId),
                     OpSig : current.OpSig,
                     Data : MemoryEncoding.Define(current.Address, data)
                );

                //dst[i] = Parse(parser, current);
            }

            ReportDuplicates(OpIdentity.duplicates(dst.Select(x => x.Uri.OpId)));

            return AsmReports.ParsedEncodings(host.Path, dst);
        }

        void ReportDuplicates(OpIdentity[] duplicated)
        {
            if(duplicated.Length != 0)
            {
                var format = string.Join(text.comma(), duplicated);
                Context.Enqueue($"Identifier duplicates: {format}", AppMsgKind.Warning);           
            }
        }
    }
}