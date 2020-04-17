//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;
    using Asm;

    public readonly struct MemoryExtractParser : IMemoryExtractParser
    {
        readonly IContext Context;

        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static MemoryExtractParser New(IContext context, int bufferlen)
            => new MemoryExtractParser(context, bufferlen);

        [MethodImpl(Inline)]
        public static MemoryExtractParser Create(IContext context, byte[] buffer)
            => new MemoryExtractParser(context, buffer);

        [MethodImpl(Inline)]
        MemoryExtractParser(IContext context, byte[] buffer)
        {
            this.Context = context;
            this.Buffer = buffer;
        }

        [MethodImpl(Inline)]
        MemoryExtractParser(IContext context, int bufferlen)
            : this(context, new byte[bufferlen])
        {}

        public Option<Addressable> Parse(Addressable src)
        {
            var parser = Context.PatternParser(Buffer.Clear());
            var status = parser.Parse(src);            
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded 
                ? Addressable.Define(src.Address, parser.Parsed.ToArray()) 
                : none<Addressable>();
        }               
    }
}