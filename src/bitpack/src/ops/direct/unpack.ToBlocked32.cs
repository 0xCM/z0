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

    partial class BitPack
    {
        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 256-bit blocks comprising 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="blocks">The number of bytes to pack</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack(in byte src, int blocks, in Block256<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref u8(buffer);
            
            for(var block=0; block < blocks; block++)
            {
                unpack(skip(src, block), ref tmp); 
                dvec.vconvert(n64, tmp, n256, n32).StoreTo(ref dst.BlockRef(block));
            }
        }
    }
}