//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Sse.X64;

    using static As;
    using static zfunc;    

    partial class inxsoc
    {
        public static unsafe float inxs_add_32f(float x, float y)        
            => AddScalar(LoadScalarVector128(constptr(in x)), LoadScalarVector128(constptr(in y))).GetElement(0);
        
        public static double inxs_add64f(double x, double y)        
            => inxs.add(x,y);

        public static float inxs_sub32f(float x, float y)        
            => inxs.sub(x,y);
        
        public static double inxs_sub64f(double x, double y)        
            => inxs.sub(x,y);

        public static float inxs_mul32f(float x, float y)        
            => inxs.mul(x,y);
        
        public static double inxs_mul64f(double x, double y)        
            => inxs.mul(x,y);

        public static float inxs_div32f(float x, float y)        
            => inxs.div(x,y);
        
        public static double inxs_div64f(double x, double y)        
            => inxs.div(x,y);

        public static float inxs_max32f(float x, float y)        
            => inxs.max(x,y);
        
        public static double inxs_max64f(double x, double y)        
            => inxs.max(x,y);

        public static float inxs_min32f(float x, float y)        
            => inxs.min(x,y);
        
        public static double inxs_min64f(double x, double y)        
            => inxs.min(x,y);
        

    }


}
