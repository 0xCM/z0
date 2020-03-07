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

        static MemberParseRecord Parse(in ByteParser<EncodingPatternKind> parser, in MemberExtractRecord current)
        {
            var status = parser.Parse(current.Data);                
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();                
            var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
            return MemberParseRecord.Define
            (
                Sequence : current.Sequence,
                Address : current.Address,
                Length : data.Length,
                TermCode: matched.ToTermCode(),
                Uri : OpUri.Hex(current.Uri.HostPath, current.Uri.GroupName, current.Uri.OpId),
                OpSig : current.OpSig,
                Data : MemoryExtract.Define(current.Address, data)
            );
        }

        public ParsedExtract[] Parse(params MemberExtract[] src)
        {
            var dst = new ParsedExtract[src.Length];
            var parser = Context.PatternParser(PatternBuffer.Clear());               
            for(var i=0; i< dst.Length; i++)
            {
                ref readonly var current = ref src[i];                
                var status = parser.Parse(current.EncodedData);                
                var matched = parser.Result;
                var succeeded = matched.IsSome() && status.Success(); 
                if(!succeeded)               
                    Context.Notify(AppMsg.Warn($"Failed to parse {current.Uri} with status = {status}"));
                var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
                dst[i] = ParsedExtract.Define(current, matched.ToTermCode(), MemoryExtract.Define(current.EncodedData.Address, data));
            }

            return dst;
        }

        public MemberParseReport Parse(ApiHost host, MemberExtractReport encoded)
        {
            var dst = new MemberParseRecord[encoded.Records.Length];
            var parser = Context.PatternParser(PatternBuffer.Clear());            
            Context.Notify($"Parsing {encoded.Records.Length} {host} records");

            for(var i=0; i< dst.Length; i++)
            {
                ref readonly var current = ref encoded.Records[i];                
                var status = parser.Parse(current.Data);                
                var matched = parser.Result;
                var succeeded = matched.IsSome() && status.Success();                
                var data = succeeded ? parser.Parsed.ToArray() : array<byte>();
                dst[i] = MemberParseRecord.Define
                (
                     Sequence : current.Sequence,
                     Address : current.Address,
                     Length : data.Length,
                     TermCode: matched.ToTermCode(),
                     Uri : OpUri.Hex(host.Path, current.Uri.GroupName, current.Uri.OpId),
                     OpSig : current.OpSig,
                     Data : MemoryExtract.Define(current.Address, data)
                );               
            }

            ReportDuplicates(OpIdentity.duplicates(dst.Select(x => x.Uri.OpId)));

            return MemberParseReport.Create(dst);
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