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
    
    public static class v512
    {                
        public static Vector512<uint> add_512x32u(Vector512<uint> x, Vector512<uint> y)
            => dinx.vadd(x,y);


        [MethodImpl(Inline)]
        public static void add_2x256x32u(Vector256<uint> x0, Vector256<uint> y0, Vector256<uint> x1, Vector256<uint> y1, out Vector256<uint> z0, out Vector256<uint> z1)        
        {
            z0 = Add(x0,y0);
            z1 = Add(x1,y1);
        }


    }

}