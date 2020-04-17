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

    public readonly struct ParsedMemoryExtract
    {
        public readonly Addressable Source;

        public readonly Addressable Parsed;

        [MethodImpl(Inline)]
        public static ParsedMemoryExtract Define(MemoryAddress src, byte[] raw, byte[] parsed)
            => new ParsedMemoryExtract(src, raw, parsed);

        [MethodImpl(Inline)]
        public static ParsedMemoryExtract Define(MemoryAddress src, Addressable raw, Addressable parsed)
            => new ParsedMemoryExtract(src, raw,parsed);

        [MethodImpl(Inline)]
        ParsedMemoryExtract(MemoryAddress src, Addressable raw, Addressable parsed)
        {
            require(src.Equals(raw.Address));
            require(src.Equals(parsed.Address));
            
            this.Source = raw;
            this.Parsed = parsed;
        }

        [MethodImpl(Inline)]
        ParsedMemoryExtract(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            this.Source = Addressable.Define(src, raw);
            this.Parsed = Addressable.Define(src, parsed);
        }
    }
}