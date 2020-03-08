//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public readonly struct MemoryExtractParser : IMemoryExtractParser
    {
        public IAsmContext Context {get;}

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static MemoryExtractParser New(IAsmContext context, int? bufferlen)
            => new MemoryExtractParser(context, bufferlen);

        [MethodImpl(Inline)]
        public static MemoryExtractParser New(IAsmContext context, byte[] buffer)
            => new MemoryExtractParser(context, buffer);

        [MethodImpl(Inline)]
        MemoryExtractParser(IAsmContext context, byte[] buffer)
        {
            this.Context = context;
            this.Buffer = buffer;
        }

        [MethodImpl(Inline)]
        MemoryExtractParser(IAsmContext context, int? bufferlen)
            : this(context, new byte[bufferlen ?? context.DefaultBufferLength])
        {}

        public Option<MemoryExtract> Parse(MemoryExtract src)
        {
            var parser = Context.PatternParser(Buffer.Clear());
            var status = parser.Parse(src);            
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded 
                ? MemoryExtract.Define(src.Address, parser.Parsed.ToArray()) 
                : none<MemoryExtract>();
        }               
    }
}