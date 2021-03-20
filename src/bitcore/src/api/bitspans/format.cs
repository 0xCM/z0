//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class BitSpans
    {
        [Op]
        public static string format(in BitSpan src, BitFormat? fmt = null)
        {
            var options = fmt ?? BitFormatter.configure();
            var bitcount = root.min(options.MaxBitCount,src.BitCount);
            var blocked = options.BlockWidth != 0;
            var blocks = (uint)(blocked ? src.Length / options.BlockWidth : 0);
            bitcount += blocks; // space for block separators

            Span<char> buffer = stackalloc char[(int)bitcount];
            ref var dst = ref first(buffer);
            var digits = 0;
            for(uint i = 0, j=bitcount-1; i<bitcount; i++, j--)
            {
                if(blocked && digits % options.BlockWidth == 0)
                    seek(dst, j--) = options.BlockSep;

                seek(dst, j) = src[i].ToChar();
                digits++;
            }

            if(options.TrimLeadingZeros)
                return new string(buffer).TrimStart(bit.Zero);
            else
                return new string(buffer);
        }
    }
}