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
        
        public readonly EncodedData Raw;

        public readonly EncodedData Parsed;

        [MethodImpl(Inline)]
        public static AsmCaptureBits Define(MemoryAddress src, byte[] raw, byte[] parsed)
            => new AsmCaptureBits(src, raw,parsed);

        [MethodImpl(Inline)]
        public static AsmCaptureBits Define(MemoryAddress src, EncodedData raw, EncodedData parsed)
            => new AsmCaptureBits(src, raw,parsed);

        [MethodImpl(Inline)]
        AsmCaptureBits(MemoryAddress src, EncodedData raw, EncodedData parsed)
        {
            require(src.Equals(raw.BaseAddress));
            require(src.Equals(parsed.BaseAddress));
            
            this.Source = src;
            this.Raw = raw;
            this.Parsed = parsed;
        }

        [MethodImpl(Inline)]
        AsmCaptureBits(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            this.Source = src;
            this.Raw = EncodedData.Define(src, raw);
            this.Parsed = EncodedData.Define(src, parsed);
        }
    }
}