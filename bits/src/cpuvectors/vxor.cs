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
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class Bits
    {
 
            
        [MethodImpl(Inline)]
        public static Vec128<byte> vxor(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<short> vxor(in Vec128<short> lhs, in Vec128<short> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> vxor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vxor(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<int> vxor(in Vec128<int> lhs, in Vec128<int> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<uint> vxor(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<long> vxor(in Vec128<long> lhs, in Vec128<long> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vxor(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<float> vxor(in Vec128<float> lhs, in Vec128<float> rhs)
            => Xor(lhs.xmm, rhs.xmm);
        
        [MethodImpl(Inline)]
        public static Vec128<double> vxor(in Vec128<double> lhs, in Vec128<double> rhs)
            => Xor(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec256<byte> vxor(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<short> vxor(in Vec256<short> lhs, in Vec256<short> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vxor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ushort> vxor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<int> vxor(in Vec256<int> lhs, in Vec256<int> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<uint> vxor(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<long> vxor(in Vec256<long> lhs, in Vec256<long> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vxor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<float> vxor(in Vec256<float> lhs, in Vec256<float> rhs)
            => Xor(lhs.ymm, rhs.ymm);
        
        [MethodImpl(Inline)]
        public static Vec256<double> vxor(in Vec256<double> lhs, in Vec256<double> rhs)
            => Xor(lhs.ymm, rhs.ymm);

        /// <summary>
        /// Computes the combined XOR of three operands
        /// </summary>
        /// <param name="x0">The first vector</param>
        /// <param name="x1">The second vector</param>
        /// <param name="x2">The third vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> xor(in Vec128<sbyte> x0, in Vec128<sbyte> x1, in Vec128<sbyte> x2)
            => Xor(Xor(x0, x1),x2);

        /// <summary>
        /// Computes the combined XOR of three operands
        /// </summary>
        /// <param name="x0">The first vector</param>
        /// <param name="x1">The second vector</param>
        /// <param name="x2">The third vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vxor(in Vec128<byte> x0, in Vec128<byte> x1, in Vec128<byte> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<short> vxor(in Vec128<short> x0, in Vec128<short> x1,  in Vec128<short> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ushort> vxor(in Vec128<ushort> x0, in Vec128<ushort> x1, in Vec128<ushort> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<int> vxor(in Vec128<int> x0, in Vec128<int> x1, in Vec128<int> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<uint> vxor(in Vec128<uint> x0, in Vec128<uint> x1, in Vec128<uint> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<long> vxor(in Vec128<long> x0, in Vec128<long> x1, in Vec128<long> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<ulong> vxor(in Vec128<ulong> x0, in Vec128<ulong> x1, in Vec128<ulong> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec128<float> xor(in Vec128<float> x0, in Vec128<float> x1, in Vec128<float> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);
        
        [MethodImpl(Inline)]
        public static Vec128<double> vxor(in Vec128<double> x0, in Vec128<double> x1, in Vec128<double> x2)
            => Xor(Xor(x0.xmm, x1.xmm),x2.xmm);

        [MethodImpl(Inline)]
        public static Vec256<byte> vxor(in Vec256<byte> x0, in Vec256<byte> x1, in Vec256<byte> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<short> vxor(in Vec256<short> x0, in Vec256<short> x1, in Vec256<short> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> vxor(in Vec256<sbyte> x0, in Vec256<sbyte> x1, in Vec256<sbyte> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ushort> xor(in Vec256<ushort> x0, in Vec256<ushort> x1, in Vec256<ushort> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<int> vxor(in Vec256<int> x0, in Vec256<int> x1, in Vec256<int> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<uint> vxor(in Vec256<uint> x0, in Vec256<uint> x1, in Vec256<uint> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<long> vxor(in Vec256<long> x0, in Vec256<long> x1, in Vec256<long> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<ulong> vxor(in Vec256<ulong> x0, in Vec256<ulong> x1, in Vec256<ulong> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);

        [MethodImpl(Inline)]
        public static Vec256<float> vxor(in Vec256<float> x0, in Vec256<float> x1, in Vec256<float> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);
        
        [MethodImpl(Inline)]
        public static Vec256<double> vxor(in Vec256<double> x0, in Vec256<double> x1, in Vec256<double> x2)
            => Xor(Xor(x0.ymm, x1.ymm),x2.ymm);
             
    }
}