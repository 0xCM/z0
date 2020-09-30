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

    using api = BitFormatter;

    /// <summary>
    /// Configurable bit data type formatter
    /// </summary>
    public readonly struct BitFormatter<T> : IBitFormatter<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public string Format(ReadOnlySpan<byte> src, in BitFormat config)
            => api.format(src,config);

        [MethodImpl(Inline)]
        public string Format(T src, in BitFormat config)
            => api.format(bytes(src), config);

        [MethodImpl(Inline)]
        public string Format(T src)
            => Format(src, BitFormatter.configure());
    }
}