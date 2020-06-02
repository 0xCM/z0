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

    partial class BitPack
    {
        /// <summary>
        /// Unpacks a specified number source bytes to a corresponding count of 32-bit target values
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="count">The number of bytes to pack</param>
        /// <param name="dst">The target reference, of size at least 256*count bits</param>
        [MethodImpl(Inline), Op]
        public static void unpack(in byte src, int count, ref uint dst)        
        {
            var buffer = z64;
            ref var tmp = ref As.uint8(ref buffer);

            for(var i = 0; i < count; i++)
            {
                unpack(skip(in src, i), ref tmp); 
                dvec.vconvert(n64, in tmp, n256, n32).StoreTo(ref seek(ref dst, i*8));
            }
        }
    }
}