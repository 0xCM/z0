//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    public readonly struct HexDataFormatter<T>
        where T : unmanaged
    {
        public readonly HexFormatOptions Config;

        public readonly byte CellSize;

        [MethodImpl(Inline)]
        public HexDataFormatter(in HexFormatOptions config)
        {
            Config = config;
            CellSize = (byte)size<T>();
        }

        [MethodImpl(Inline)]
        public void Format(ReadOnlySpan<T> src, StringBuilder dst)
            => Hex.render(src,Config,dst);

        public string Format(ReadOnlySpan<T> src)
        {
            var dst = text.build();
            Format(src,dst);
            return dst.ToString();
        }
    }
}