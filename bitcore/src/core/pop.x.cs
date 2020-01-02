//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    
    using static zfunc;

    partial class BitsX
    {
               
        [MethodImpl(Inline)]   
        public static ulong PopCount(this Span<byte> src)
        {
            var count = 0ul;            
            for(var i = 0; i < src.Length; i++)
                count += Bits.pop(src[i]);
            return count;
        }
    }

}