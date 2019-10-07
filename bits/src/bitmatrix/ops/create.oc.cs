//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static zfunc;
    using static As;

    partial class bmoc
    {
        public static BitMatrix64 bm_from_natspan_64x64x64u(in Span<N64,ulong> src)
            => BitMatrix64.From(src);
    }

}