//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial struct BitSpan
    {
        public static string format(in BitSpan src, BitFormat? fmt = null)
        {
            var options = fmt ?? BitFormat.Default;
            var bitcount = src.Length;
            var blocked = options.BlockWidth != 0;
            var blocks = blocked ? src.Length / options.BlockWidth : 0;                        
            bitcount += blocks; // space for block separators

            Span<char> buffer = stackalloc char[bitcount];
            ref var dst = ref head(buffer);
            
            var digits = 0;
            for(int i = 0, j=bitcount-1; i < bitcount; i++, j--)
            {
                if(blocked && digits % options.BlockWidth == 0)
                    seek(ref dst, j--) = options.BlockSep;

                seek(ref dst, j) = src[i].ToChar();
                digits++;
            }
            
            return new string(buffer);
        }
    }
}