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
    using System.Runtime.InteropServices;    
    
    using static zfunc;

    partial class BitsX
    {

               
        [MethodImpl(Inline)]   
        public static ulong PopCount(this Span<byte> src)
            => bitspan.pop(src);
    }

}