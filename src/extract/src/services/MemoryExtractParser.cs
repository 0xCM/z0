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

    public readonly struct MemoryExtractParser : IMemoryExtractParser
    {
        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        public static MemoryExtractParser Create(int bufferlen)
            => new MemoryExtractParser(bufferlen);

        [MethodImpl(Inline)]
        public static MemoryExtractParser Create(byte[] buffer)
            => new MemoryExtractParser(buffer);

        [MethodImpl(Inline)]
        MemoryExtractParser(byte[] buffer)
        {
            this.Buffer = buffer;
        }

        [MethodImpl(Inline)]
        MemoryExtractParser(int bufferlen)
            : this(new byte[bufferlen])
        {}

        public Option<LocatedCode> Parse(LocatedCode src)
        {
            var parser = Extract.Services.PatternParser(Buffer.Clear());
            var status = parser.Parse(src);            
            var matched = parser.Result;
            var succeeded = matched.IsSome() && status.Success();
            return succeeded 
                ? LocatedCode.Define(src.Address, parser.Parsed.ToArray()) 
                : none<LocatedCode>();
        }               
    }
}