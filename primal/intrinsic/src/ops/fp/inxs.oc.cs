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

    using static zfunc;    

    public static partial class voc
    {
        public static Vector128<float> vadd_scalar128_n32f(Vector128<float> x, Vector128<float> y)
            => Sse.AddScalar(x,y);

        public static Scalar128<float> vadd_scalar128_d32f(in Scalar128<float> x, in Scalar128<float> y)
            => inxs.add(x,y);

        public static Scalar128<float> vadd_scalar128_g32f(in Scalar128<float> x, in Scalar128<float> y)
            => ginxs.add(in x, in y);

    }

}
