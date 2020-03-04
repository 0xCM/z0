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

    public readonly struct AsmEncodingParser : IAsmEncodingParser
    {
        public IAsmContext Context {get;}

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static AsmEncodingParser Create(IAsmContext context, int? bufferlen)
            => new AsmEncodingParser(context, bufferlen);

        [MethodImpl(Inline)]
        public static AsmEncodingParser Create(IAsmContext context, byte[] buffer)
            => new AsmEncodingParser(context, buffer);

        [MethodImpl(Inline)]
        AsmEncodingParser(IAsmContext context, byte[] buffer)
        {
            this.Context = context;
            this.Buffer = buffer;
        }

        [MethodImpl(Inline)]
        AsmEncodingParser(IAsmContext context, int? bufferlen)
            : this(context, new byte[bufferlen ?? context.DefaultBufferLength])
        {}

        public Option<EncodedData> Parse(EncodedData src)
        {
            var parser = Context.PatternParser(Buffer.Clear());
            var status = parser.Parse(src);            
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded 
                ? EncodedData.Define(src.BaseAddress, parser.Parsed.ToArray()) 
                : none<EncodedData>();
        }               
    }

}        

