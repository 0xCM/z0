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
        
    partial struct Render
    {
        [Op]
        public static ReadOnlySpan<char> bitchars(byte[] src)
        {   
            var dst = span<char>(src.Length*8);
            var input = span(src);
            var config = BitFormatConfig.Default;
            bits(src, dst.Length, dst);
            return dst;
        }
    }
}