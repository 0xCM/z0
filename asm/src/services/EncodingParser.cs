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
    
    using static zfunc;

    public readonly struct EncodingParser : IEncodingParser
    {
        public IAsmContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IEncodingParser Create(IAsmContext context, int? maxlen = null)
            => new EncodingParser(context,maxlen);

        [MethodImpl(Inline)]
        EncodingParser(IAsmContext context, int? maxlen)
        {
            this.Context = context;
            this.BufferLength = maxlen ?? Pow2.T14;
        }

        public ParsedEncodingReport Parse(ApiHost host, CapturedEncodingReport encoded)
        {
            var dst = new ParsedEncodingRecord[encoded.Records.Length];
            var buffer = alloc<byte>(BufferLength);
            var parser = EncodingParser.ByteParser(Context, BufferLength);
            
            print($"Parsing {encoded.Records.Length} {host} records");

            for(var i=0; i< dst.Length; i++)
            {
                var current = encoded.Records[i];
                var status = parser.Parse(current.Data);
                
                var matched = parser.Result;
                var succeeded = matched.IsSome() && status.Success();
                
                if(!succeeded)
                    print($"Parse failure: {matched}, {current.Uri}", SeverityLevel.Warning);

                var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
                dst[i] = new ParsedEncodingRecord
                {
                     Sequence = current.Sequence,
                     Address = current.Address,
                     Length = data.Length,
                     TermCode = matched.ToTermCode(),
                     Uri = OpUri.Hex(host.Path, current.Uri.OpGroup, current.Uri.OpId),
                     Data = data,
                };
            }

            ReportDuplicates(dst.Select(x => x.Uri.OpId).Duplicates());

            return ParsedEncodingReport.Create(dst);
        }

        static ByteParser<EncodingPatternKind> ByteParser(IAsmContext context, int size)
            => ByteParser<EncodingPatternKind>.Create(context, size, EncodingPatterns.Define());

        void ReportDuplicates(OpIdentity[] duplicated)
        {
            if(duplicated.Length != 0)
            {
                var format = string.Join(text.comma(), duplicated);
                print($"Identifier duplicates: {format}", SeverityLevel.Warning);           
            }
        }
    }
}