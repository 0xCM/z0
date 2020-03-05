//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;    

    public readonly struct AsmCaptureBits
    {
        readonly MemoryAddress Source;
        
        public readonly MemoryEncoding Raw;

        public readonly MemoryEncoding Parsed;

        [MethodImpl(Inline)]
        public static AsmCaptureBits Define(MemoryAddress src, byte[] raw, byte[] parsed)
            => new AsmCaptureBits(src, raw,parsed);

        [MethodImpl(Inline)]
        public static AsmCaptureBits Define(MemoryAddress src, MemoryEncoding raw, MemoryEncoding parsed)
            => new AsmCaptureBits(src, raw,parsed);

        [MethodImpl(Inline)]
        AsmCaptureBits(MemoryAddress src, MemoryEncoding raw, MemoryEncoding parsed)
        {
            require(src.Equals(raw.Address));
            require(src.Equals(parsed.Address));
            
            this.Source = src;
            this.Raw = raw;
            this.Parsed = parsed;
        }

        [MethodImpl(Inline)]
        AsmCaptureBits(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            this.Source = src;
            this.Raw = MemoryEncoding.Define(src, raw);
            this.Parsed = MemoryEncoding.Define(src, parsed);
        }
    }
}