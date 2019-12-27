//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    partial class inxoc
    {                
        

        public static Vector256<short> add_d256x16i(Vector256<short> x, Vector256<short> y)
            => dinx.vadd(x,y);

        public static Vector256<short> add_g256x16i(Vector256<short> x, Vector256<short> y)
            => ginx.vadd(x,y);

        public static Vector256<short> add_o256x16i(Vector256<short> x, Vector256<short> y)
            => Pipes.apply(x,y,VOps.vadd(n256,z16i));
            
        public static Vector256<short> abs_d256x16i(Vector256<short> src)
            => dinx.vabs(src);

        public static Vector256<short> abs_g256x16i(Vector256<short> src)
            => ginx.vabs(src);

        public static Vector256<short> abs_o256x16i(Vector256<short> src)
            => Pipes.apply(src, VOps.vabs(n256,z16i));

        public static Vector256<short> sub_d256x16i(Vector256<short> x, Vector256<short> y)
            => dinx.vsub(x,y);

        public static Vector256<short> sub_g256x16i(Vector256<short> x, Vector256<short> y)
            => ginx.vsub(x,y);

        public static Vector256<short> sub_o256x16i(Vector256<short> x, Vector256<short> y)
            => OpCapture.vbinary(n256,VOps.vsub(n256,z16i),z16i).Invoke(x,y);
    }

}