//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;    
    
    public static class bitpack
    {                
        public static void unpack_64x32(ulong src, Span<uint> dst)
            => BitPack.unpack32(src,dst);

    }

}