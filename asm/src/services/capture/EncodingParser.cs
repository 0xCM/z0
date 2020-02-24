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
        public IRngContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IEncodingParser Create(IRngContext context, int? maxlen = null)
            => new EncodingParser(context,maxlen);

        [MethodImpl(Inline)]
        EncodingParser(IRngContext context, int? maxlen)
        {
            this.Context = context;
            this.BufferLength = maxlen ?? Pow2.T14;
        }

        public ParsedEncodings Parse(ApiHost host, CapturedEncodings encoded)
        {
            var dst = new ParsedEncoding[encoded.Records.Length];
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
                    print($"Parse failure", SeverityLevel.Warning);

                var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
                dst[i] = new ParsedEncoding
                {
                     Sequence = current.Sequence,
                     TermCode = matched.ToTermCode(),
                     Length = data.Length,
                     Uri = OpUri.Hex(host.Path, current.OpName, current.OpId),
                     Data = data,
                };
            }

            ReportDuplicates(dst.Select(x => x.Uri.OpId).Duplicates());

            return ParsedEncodings.Create(dst);
        }

        static ByteParser<EncodingPatternKind> ByteParser(IRngContext context, int size)
            => ByteParser<EncodingPatternKind>.Create(context, size, new EncodingPatterns(0));

        void ReportDuplicates(OpIdentity[] duplicated)
        {
            if(duplicated.Length != 0)
            {
                var format = string.Join(comma(), duplicated);
                print($"Identifier duplicates: {format}", SeverityLevel.Warning);           
            }
        }
    }
}