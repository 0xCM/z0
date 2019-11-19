//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    using static As;
 
    partial class BitParts
    {        

        [MethodImpl(Inline)]
        public static void part64x32(ulong src, Span<uint> dst)
            => head64(dst) = src;

        [MethodImpl(Inline)]
        public static void part64x32(ulong src, ref uint dst)
            => uint64(ref dst) = src;

    }

}