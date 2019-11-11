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

    public static class Compress
    {    

        [MethodImpl(Inline)]
        public static Vector128<byte> gather(Vector128<ushort> x, Vector128<ushort> y)
            => dinx.vpackus(x,y);

        [MethodImpl(Inline)]
        public static Vector128<ushort> gather(Vector128<uint> x, Vector128<uint> y)
            => dinx.vpackus(x,y);

        [MethodImpl(Inline)]
        public static Vector256<byte> gather(Vector256<short> x, Vector256<short> y)            
            => dinx.vpackus(x,y);

        [MethodImpl(Inline)]
        public static Vector256<ushort> gather(Vector256<uint> x, Vector256<uint> y)            
            => dinx.vpackus(x,y);

        [MethodImpl(Inline)]
        public static void spread(Vector128<byte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            var dst = spread(src, out Vector256<ushort> _);
            lo = dinx.vlo(dst);
            hi = dinx.vhi(dst);
        }

        // [MethodImpl(Inline)]
        // public static void spread(Vector128<byte> src, out Vector128<uint> x0, out Vector128<uint> x1, out Vector128<uint> x2, out Vector128<uint> x3)
        // {   
            

        // }
        

        [MethodImpl(Inline)]
        public static ref Vector256<ushort> spread(Vector128<byte> src, out Vector256<ushort> dst)
            => ref dinx.vconvert(src, out dst);


        // [MethodImpl(Inline)]
        // public static void spread(Vector128<byte> src, out Vector256<uint> lo, out Vector256<uint> hi)
        // {
        //     dinx.vconvert(src, out lo, out hi);
        // }



    }

}