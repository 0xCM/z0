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
        public readonly LocatedCode Source;

        public readonly LocatedCode Parsed;

        [MethodImpl(Inline)]
        public static ParsedMemoryExtract Define(MemoryAddress src, byte[] raw, byte[] parsed)
            => new ParsedMemoryExtract(src, raw, parsed);

        [MethodImpl(Inline)]
        public static ParsedMemoryExtract Define(MemoryAddress src, LocatedCode raw, LocatedCode parsed)
            => new ParsedMemoryExtract(src, raw,parsed);

        [MethodImpl(Inline)]
        ParsedMemoryExtract(MemoryAddress src, LocatedCode raw, LocatedCode parsed)
        {
            require(src.Equals(raw.Address));
            require(src.Equals(parsed.Address));
            
            this.Source = raw;
            this.Parsed = parsed;
        }

        [MethodImpl(Inline)]
        ParsedMemoryExtract(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            this.Source = LocatedCode.Define(src, raw);
            this.Parsed = LocatedCode.Define(src, parsed);
        }
    }
}