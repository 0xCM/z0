//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;
    using static dinx;

    partial class Bits
    {
        // const ulong k1 = 0x5555555555555555;
        
        // const ulong k2 = 0x3333333333333333;
        
        // const ulong k4 = 0x0f0f0f0f0f0f0f0f;
        
        // const ulong kf = 0x0101010101010101; 

        static Vector256<ulong> K1 => CpuVector.broadcast(n256, k1);

        static Vector256<ulong> K2 => CpuVector.broadcast(n256, k2);

        static Vector256<ulong> K4 => CpuVector.broadcast(n256, k4);        

        static Vector128<ulong> v128K1 => CpuVector.broadcast(n128, k1);

        static Vector128<ulong> v128K2 => CpuVector.broadcast(n128, k2);

        static Vector128<ulong> v128K4 => CpuVector.broadcast(n128, k4);

        /// <summary>
        /// Computes the population count of the content of 3 128-bit vectors
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <remarks>
        /// This is a vectorization of the scalar algorithm found at https://www.chessprogramming.org/Population_Count
        /// </remarks>
        [MethodImpl(Inline)]
        public static uint vpop(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z)
        {
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

            var dst = StackStore.alloc(n128);
            vstore(odd, ref dst.X0);
            var total = 0ul;

            total += (dst.X0 * kf) >> 56;
            total += (dst.X1 * kf) >> 56;

            return (uint)total;            
        }

        /// <summary>
        /// Computes the population count of the content of 3 256-bit vectors
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <remarks>
        /// This is a vectorization of the scalar algorithm found at https://www.chessprogramming.org/Population_Count
        /// </remarks>
        [MethodImpl(Inline)]
        public static uint vpop(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
        {
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

            var dst = StackStore.alloc(n256);
            ref var X = ref StackStore.head(ref dst);
            vstore(odd, ref X);
            
            var total = 0ul;
            total += (seek(ref X, 0) * kf) >> 56;
            total += (seek(ref X, 1) * kf) >> 56;
            total += (seek(ref X, 2) * kf) >> 56;
            total += (seek(ref X, 3) * kf) >> 56;

            return (uint)total;            
        }
 
    }
}