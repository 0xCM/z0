//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct VSym
    {
        [MethodImpl(Inline)]
        static Vector128<byte> vcompact(Vector256<ushort> src, W8 w)            
            => dvec.vpackus(vlo(src), vhi(src));

        /// <summary>
        /// Converts 16 source characters to 16 asci codes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The soruce offset</param>
        /// <param name="count">The number of source characters to convert</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline), Op]
        public static void encode(in char src, int offset, N16 count, ref AsciCharCode dst)
        {            
            ref readonly var input = ref Symbolic.read(src,offset);
            ref var target = ref asci.write(ref dst);
            V0.vsave(vcompact(V0.vload(w256, input), w8), ref target);        
        }
    }
}