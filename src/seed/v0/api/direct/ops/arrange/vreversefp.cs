//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static Konst;
    using static Typed;

    partial struct V0d
    {
 
        [MethodImpl(Inline), Op]
        public static Vector256<float> vreverse(Vector256<float> src)
            => vperm8x32(src,MRev256f32);    

        static Vector256<int> MRev256f32 
            => V0.vparts(w256i, 7, 6, 5, 4, 3, 2, 1, 0);    
    }
}