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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;
    
    partial class zfoc
    {
        public static unsafe void vstore_n128x8u(Vector128<byte> src, ref byte dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x8u(Vec128<byte> src, ref byte dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x8u(Vec128<byte> src, ref byte dst)
            => vstore(src, ref dst);
        /*
        VEX.[NDS].<BitWidth>.[66 | F2 | F3].[0F | 0F3A | 0F38].<WIG | W0 | W1>
                             ^ VEX.pp        ^ Opcocde map     ^ Treatment of VEX.W field
        ;VEX.128.66.0F.WIG 10 /r VMOVUPD xmm1, xmm2/m128
        ;Moves 128 bits of packed double-precision floating-point values from the source operand (second operand) to the destination operand (first operand)
        ;Op1 = ModRM:reg (w)
        ;Op2 = ModRM:r/m (r)
        ;c5 f9 10 01
        vmovupd xmm0,[rcx]            
        */

        public static unsafe void vstore_n128x8i(Vector128<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x8i(Vec128<sbyte> src, ref sbyte dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x8i(Vec128<sbyte> src, ref sbyte dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x16i(Vector128<short> src, ref short dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x16i(Vec128<short> src, ref short dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x16i(Vec128<short> src, ref short dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x16u(Vector128<ushort> src, ref ushort dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x16u(Vec128<ushort> src, ref ushort dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x16u(Vec128<ushort> src, ref ushort dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x32i(Vector128<int> src, ref int dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x32i(Vec128<int> src, ref int dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x32i(Vec128<int> src, ref int dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x32u(Vector128<uint> src, ref uint dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x32u(Vec128<uint> src, ref uint dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x32u(Vec128<uint> src, ref uint dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x64i(Vector128<long> src, ref long dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x64i(Vec128<long> src, ref long dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x64i(Vec128<long> src, ref long dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x64u(Vector128<ulong> src, ref ulong dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x64u(Vec128<ulong> src, ref ulong dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x64u(Vec128<ulong> src, ref ulong dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x32f(Vector128<float> src, ref float dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x32f(Vec128<float> src, ref float dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x32f(Vec128<float> src, ref float dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n128x64f(Vector128<double> src, ref double dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d128x64f(Vec128<double> src, ref double dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g128x64f(Vec128<double> src, ref double dst)
            => vstore(src, ref dst);

         public static unsafe void vstore_n256x8u(Vector256<byte> src, ref byte dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x8u(Vec256<byte> src, ref byte dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x8u(Vec256<byte> src, ref byte dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x8i(Vector256<sbyte> src, ref sbyte dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x8i(Vec256<sbyte> src, ref sbyte dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x8i(Vec256<sbyte> src, ref sbyte dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x16i(Vector256<short> src, ref short dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x16i(Vec256<short> src, ref short dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x16i(Vec256<short> src, ref short dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x16u(Vector256<ushort> src, ref ushort dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x16u(Vec256<ushort> src, ref ushort dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x16u(Vec256<ushort> src, ref ushort dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x32i(Vector256<int> src, ref int dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x32i(Vec256<int> src, ref int dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x32i(Vec256<int> src, ref int dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x32u(Vector256<uint> src, ref uint dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x32u(Vec256<uint> src, ref uint dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x32u(Vec256<uint> src, ref uint dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x64i(Vector256<long> src, ref long dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x64i(Vec256<long> src, ref long dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x64i(Vec256<long> src, ref long dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x64u(Vector256<ulong> src, ref ulong dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x64u(Vec256<ulong> src, ref ulong dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x64u(Vec256<ulong> src, ref ulong dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x32f(Vector256<float> src, ref float dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x32f(Vec256<float> src, ref float dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x32f(Vec256<float> src, ref float dst)
            => vstore(src, ref dst);

        public static unsafe void vstore_n256x64f(Vector256<double> src, ref double dst)
            => Store(refptr(ref dst), src);            

        public static void vstore_d256x64f(Vec256<double> src, ref double dst)
            => cpuvec.vstore(src, ref dst);

        public static void vstore_g256x64f(Vec256<double> src, ref double dst)
            => vstore(src, ref dst);

    }

}