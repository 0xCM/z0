//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static z;
    using static Konst;
    
    /// <summary>
    /// Configurable bit data type formatter
    /// </summary>
    public readonly struct BitFormatter<T> : IBitFormatter<T>
        where T : struct
    {                                  
        [MethodImpl(Inline)]
        public string Format(ReadOnlySpan<byte> src, in BitFormatConfig config)
            => BitFormatter.format(src,config);
        
        [MethodImpl(Inline)]
        public void Format(ReadOnlySpan<byte> src, int maxbits, Span<char> dst)
            => BitFormatter.Service.Format(src, maxbits, dst);
        
        [MethodImpl(Inline)]
        public string Format(T src, in BitFormatConfig config)
            => BitFormatter.format(bytes(src), config);

        [MethodImpl(Inline)]
        public string Format(T src)
            => Format(src, BitFormatter.configure());
    }
}