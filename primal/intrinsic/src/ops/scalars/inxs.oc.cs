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

    public static partial class voc
    {
        public static Vector128<float> vadd_scalar128_n32f(Vector128<float> x, Vector128<float> y)
            => Sse.AddScalar(x,y);

        public static Scalar128<float> vadd_scalar128_d32f(in Scalar128<float> x, in Scalar128<float> y)
            => inxs.add(x,y);

        public static Scalar128<float> vadd_scalar128_g32f(in Scalar128<float> x, in Scalar128<float> y)
            => ginxs.add(in x, in y);

        public static unsafe Vector128<float> load_scalar128_n32f(float src)
            => LoadScalarVector128(refptr(ref asRef(in src)));

        public static Scalar128<float> load_scalar128_d32f(float src)
            => inxs.load(src);

        public static Scalar128<float> load_scalar128_g32f(float src)
            => ginxs.load(src);

        public static unsafe Vector128<double> load_scalar128_n64f(double src)
            => LoadScalarVector128(refptr(ref asRef(in src)));

        public static Scalar128<double> load_scalar128_d64f(double src)
            => inxs.load(src);

        public static Scalar128<double> load_scalar128_g64f(double src)
            => ginxs.load(in src);


        public static float to32f(int src)        
            => ConvertScalarToVector128Single(default, src).GetElement(0);

        public static unsafe int to32i(float src)
            => ConvertToInt32WithTruncation(LoadScalarVector128(refptr(ref src)));

        public static unsafe int to32i(double src)
            => ConvertToInt32WithTruncation(LoadScalarVector128(refptr(ref src)));

        public static float to32f(long src)        
            => ConvertScalarToVector128Single(default, src).GetElement(0);


        public static unsafe long to64i(float src)
            => ConvertToInt64WithTruncation(LoadScalarVector128(refptr(ref src)));

    }


}
