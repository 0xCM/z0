//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
        
    using static Memories;
    using static BitPop;

    partial class dvec
    {
        /// <summary>
        /// Computes the population count of the content of 3 128-bit vectors
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="z">The third vector</param>
        /// <remarks>
        /// This is a vectorization of the scalar algorithm found at https://www.chessprogramming.org/Population_Count
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static uint vpop(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z)
        {
            const ulong kf = BitMasks.Lsb64x8x1;            

            var k1 = v128K1;
            var k2 = v128K2;
            var k4 = v128K4;
            var maj =  vor(vand(vxor(x,y),z), vand(x,y));
            var odd =  vxor(vxor(x,y),z);
            
            maj = vsub(maj, vand(vsrl(maj, 1), k1));
            odd = vsub(odd, vand(vsrl(odd, 1), k1));
            
            maj = vadd(vand(maj,k2), vand(vsrl(maj, 2), k2));
            odd = vadd(vand(odd,k2), vand(vsrl(odd, 2), k2));

            maj = vand(vadd(maj, vsrl(maj,4)), k4);
            odd = vand(vadd(odd, vsrl(odd,4)), k4);
            
            odd = vadd(vadd(maj, maj), odd);

            var dst = Stacks.alloc(n128);
            Vectors.vstore(odd, ref dst.X0);
            var total = 0ul;

            total += (dst.X0 * kf) >> 56;
            total += (dst.X1 * kf) >> 56;

            return (uint)total;            
        }

        /// <summary>
        /// Computes the population count of the content of 3 256-bit vectors
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="z">The third vector</param>
        /// <remarks>
        /// This is a vectorization of the scalar algorithm found at https://www.chessprogramming.org/Population_Count
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static uint vpop(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
        {
            const ulong kf = BitMasks.Lsb64x8x1; 

            var k1 = K1;
            var k2 = K2;
            var k4 = K4;
            var maj =  vor(vand(vxor(x,y),z), vand(x,y));
            var odd =  vxor(vxor(x,y),z);
            
            maj = vsub(maj, vand(vsrl(maj, 1), k1));
            odd = vsub(odd, vand(vsrl(odd, 1), k1));
            
            maj = vadd(vand(maj,k2), vand(vsrl(maj, 2), k2));
            odd = vadd(vand(odd,k2), vand(vsrl(odd, 2), k2));

            maj = vand(vadd(maj, vsrl(maj,4)), k4);
            odd = vand(vadd(odd, vsrl(odd,4)), k4);
            
            odd = vadd(vadd(maj, maj), odd);

            var dst = Stacks.alloc(n256);
            ref var X = ref Stacks.head(ref dst, z64);
            Vectors.vstore(odd, ref X);
            
            var total = 0ul;
            total += (seek(ref X, 0) * kf) >> 56;
            total += (seek(ref X, 1) * kf) >> 56;
            total += (seek(ref X, 2) * kf) >> 56;
            total += (seek(ref X, 3) * kf) >> 56;

            return (uint)total;            
        }
    }

    public static class BitPop
    {        
        public static Vector256<ulong> K1 => Vectors.vbroadcast(n256, BitMasks.Even64);

        public static Vector256<ulong> K2 => Vectors.vbroadcast(n256, BitMasks.Even64x2);

        public static Vector256<ulong> K4 => Vectors.vbroadcast(n256, BitMasks.Lsb64x8x4);        

        public static Vector128<ulong> v128K1 => Vectors.vbroadcast(n128, BitMasks.Even64);

        public static Vector128<ulong> v128K2 => Vectors.vbroadcast(n128, BitMasks.Even64x2);

        public static Vector128<ulong> v128K4 => Vectors.vbroadcast(n128, BitMasks.Lsb64x8x4);
    }
}