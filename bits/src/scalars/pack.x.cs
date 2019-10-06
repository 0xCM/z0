//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class BitsX
    {       
        [MethodImpl(Inline)]        
        public static Span<byte> Unpack(this Span<byte> src)
            => BitParts.unpack8x1(src, new byte[src.Length*8]);
    }

}