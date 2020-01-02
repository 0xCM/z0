//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    [OpCodeProvider]
    public static class vconvert
    {                
        [MethodImpl(Inline)]
        public static Vector128<uint> convert(Vector256<ulong> src, N128 w, uint t = default)
            => dinx.convert(src,w,t);

        [MethodImpl(Inline)]
        public static sbyte vmovelo_8i(Vector128<sbyte> src, N8 w)   
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static byte vmovelo_8u(Vector128<byte> src, N8 w)   
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static short vmovelo_16i(Vector128<short> src, N16 w)
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static ushort vmovelo_16u(Vector128<ushort> src, N16 w)   
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static int vmovelo_32i(Vector128<int> src, N32 w)   
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static uint vmovelo_32u(Vector128<uint> src, N32 w)   
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static long vmovelo_64i(Vector128<long> src, N64 w)   
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static ulong vmovelo_64u(Vector128<ulong> src, N64 w)
            => dinx.vmovelo(src,w);

        [MethodImpl(Inline)]
        public static Vector128<float> vmovelo_32x128x32(int src, Vector128<float> dst)
            => dinx.vmovelo(src,dst);

        [MethodImpl(Inline)]
        public static Vector128<double> movelo_32x128x64(int src, Vector128<double> dst)
            => dinx.vmovelo(src,dst);

        [MethodImpl(Inline)]
        public static Vector128<double> movelo_64x128x64(long src, Vector128<double> dst)
            => dinx.vmovelo(src,dst);

        [MethodImpl(Inline)]
        public static Vector128<ulong> vmovelo_32x128x64u(Vector128<uint> src, Vector128<ulong> dst)
            => dinx.vmovelo(src,dst);

        [MethodImpl(Inline)]
        public static Vector128<long> vmovelo_32x128x64i(Vector128<int> src, Vector128<long> dst)
            => dinx.vmovelo(src,dst);

        [MethodImpl(Inline)]
        public static Vector128<double> vmovelo_32x128x64f(Vector128<float> src, Vector128<double> dst)
            => dinx.vmovelo(src,dst);
    }
}
