//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    
    using static zfunc;

    public interface IEncodingParser : IAppService
    {
        ParsedEncodings Parse(ApiHost src, CapturedEncodings encoded);        
    }

    public readonly struct EncodingParser : IEncodingParser
    {
        public IContext Context {get;}

        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IEncodingParser Create(IContext context, int? maxlen = null)
            => new EncodingParser(context,maxlen);

        [MethodImpl(Inline)]
        EncodingParser(IContext context, int? maxlen)
        {
            this.Context = context;
            this.BufferLength = maxlen ?? Pow2.T14;
        }

        static ByteParser<EncodingPatternKind> ByteParser(IContext context, int size)
            => ByteParser<EncodingPatternKind>.Create(context, size, new EncodingPatterns(0));

        const int idPad = 50;

        const int statusPad = 16;

        const int codePad = 16;

        const int lengthPad = 8;

        const string sep = " | ";
        
        static OpIdentity[] Duplicates(IEnumerable<OpIdentity> identities)
        {
            var index = new Dictionary<OpIdentity,int>();            
            var distinct = identities.ToSet();
            if(distinct.Count != identities.Count())
            {
                foreach(var id in identities)
                {
                    if(index.TryGetValue(id, out var count ))
                        index[id] = ++count;
                    else
                        index[id] = 1;
                }
            }

            return (from kvp in index where kvp.Value > 1 select kvp.Key).ToArray();
        }

        void Parse(HexLine src, ByteParser<EncodingPatternKind> parser, StreamWriter dst)
        {
            (var id, var data) = src;

            var status = parser.Parse(data);
            var contented = parser.Result.IsSome() && status.Success();
            var datafmt = contented ? parser.Parsed.FormatHex() : string.Empty;                
            var length = contented ? parser.Parsed.Length : 0;
            var csvline = string.Join(sep,
                id.ToString().PadRight(idPad),
                status.ToString().PadRight(statusPad), 
                parser.Result.ToString().PadRight(codePad),            
                length.ToString().PadRight(lengthPad),        
                datafmt);
            dst.WriteLine(csvline); 

        }

        void Parse(FilePath srcpath, FilePath dstpath)
        {
            var parser = EncodingParser.ByteParser(Context, BufferLength);

            using var src = srcpath.Reader();
            using var dst = dstpath.Writer();

            var header = string.Join(sep, 
                "OpId".PadRight(idPad), 
                "Status".PadRight(statusPad), 
                "Code".PadRight(codePad),
                "Length".PadRight(lengthPad),
                "Parsed"
                );
            dst.WriteLine(header);
            
            var txtLine = src.ReadLine();
            while(txtLine != null)
            {
                Parse(HexLine.Parse(txtLine).Require(),parser,dst);                
                txtLine = src.ReadLine();
            }
        }

        void ReportDuplicates(OpIdentity[] duplicated)
        {
            if(duplicated.Length != 0)
            {
                var format = string.Join(comma(), duplicated);
                print($"Identifier duplicates: {format}", SeverityLevel.Warning);           
            }
        }

        public ParsedEncodings Parse(ApiHost host, CapturedEncodings encoded)
        {
            var dst = new ParsedEncoding[encoded.Records.Length];
            var buffer = span<byte>(BufferLength);
            var parser = EncodingParser.ByteParser(Context, BufferLength);
            
            for(var i=0; i< dst.Length; i++)
            {
                var current = encoded.Records[i];
                var status = parser.Parse(current.Data);
                var matched = parser.Result;
                var succeeded = matched.IsSome() && status.Success();
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
    }
}