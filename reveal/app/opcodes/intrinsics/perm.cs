//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;    

    [OpCodeProvider]
    public static class vperm
    {

        [MethodImpl(NotInline)]
        static Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> vand_delgate()
        {
            var mAnd = typeof(Avx2).GetMethod(nameof(Avx2.And), new Type[] { typeof(Vector256<uint>), typeof(Vector256<uint>) });
            var mDel = mAnd.BinOpCalli<Vector256<uint>>();
            return mDel;

        }
        public static Vector256<uint> vand_dynamic(Vector256<uint> a, Vector256<uint> b)
        {
            return vand_delgate()(a,b);
        }

        public static Vector512<ulong> vperm2x128(Vector512<ulong> src)     
            => ginx.vperm2x128(src,Perm2x4.AD,Perm2x4.BC);

        public static Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
            => dinx.vbyteswap(x);
            
        public static Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
            => dinx.vperm8x32(src,spec);

        public static Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
            => dinx.vperm8x32(src,spec);

        public static Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
            => dinx.vshuf32x8(a,spec);
 
        public static Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
            => dinx.vshuf16x8(src,spec);

        public static Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
            => dinx.vshuf16x8(src,spec);

        public static Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
            => dinx.vshuf16x8(src,spec);

        public static Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
            => dinx.vshuf16x8(src,spec);

    }
}