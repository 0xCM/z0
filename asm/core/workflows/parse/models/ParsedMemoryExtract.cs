//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;    

    public readonly struct ParsedMemoryExtract
    {
        public readonly MemoryExtract Source;

        public readonly MemoryExtract Parsed;

        [MethodImpl(Inline)]
        public static ParsedMemoryExtract Define(MemoryAddress src, byte[] raw, byte[] parsed)
            => new ParsedMemoryExtract(src, raw, parsed);

        [MethodImpl(Inline)]
        public static ParsedMemoryExtract Define(MemoryAddress src, MemoryExtract raw, MemoryExtract parsed)
            => new ParsedMemoryExtract(src, raw,parsed);

        [MethodImpl(Inline)]
        ParsedMemoryExtract(MemoryAddress src, MemoryExtract raw, MemoryExtract parsed)
        {
            require(src.Equals(raw.Address));
            require(src.Equals(parsed.Address));
            
            this.Source = raw;
            this.Parsed = parsed;
        }

        [MethodImpl(Inline)]
        ParsedMemoryExtract(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            this.Source = MemoryExtract.Define(src, raw);
            this.Parsed = MemoryExtract.Define(src, parsed);
        }
    }
}