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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static As;
    using static zfunc;

    partial class dinx
    {         
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vxor1(in Vec128<sbyte> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<sbyte>), default(Vector128<sbyte>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vxor1(in Vec128<byte> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<byte>), default(Vector128<byte>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vxor1(in Vec128<short> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<short>), default(Vector128<short>)));


        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vxor1(in Vec128<ushort> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<ushort>), default(Vector128<ushort>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vxor1(in Vec128<int> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<int>), default(Vector128<int>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vxor1(in Vec128<uint> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<uint>), default(Vector128<uint>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vxor1(in Vec128<long> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<long>), default(Vector128<long>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vxor1(in Vec128<ulong> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<ulong>), default(Vector128<ulong>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vxor1(in Vec128<float> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<float>), default(Vector128<float>)));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vxor1(in Vec128<double> x)
            => Xor(x.xmm, CompareEqual(default(Vector128<double>), default(Vector128<double>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vxor1(in Vec256<sbyte> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<sbyte>), default(Vector256<sbyte>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vxor1(in Vec256<byte> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<byte>), default(Vector256<byte>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vxor1(in Vec256<short> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<short>), default(Vector256<short>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vxor1(in Vec256<ushort> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<ushort>), default(Vector256<ushort>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vxor1(in Vec256<int> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<int>), default(Vector256<int>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vxor1(in Vec256<uint> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<uint>), default(Vector256<uint>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vxor1(in Vec256<long> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<long>), default(Vector256<long>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vxor1(in Vec256<ulong> x)
            => Xor(x.ymm, CompareEqual(default(Vector256<ulong>), default(Vector256<ulong>)));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vxor1(in Vec256<float> x)
            => Xor(x.ymm, Compare(default(Vector256<float>), default(Vector256<float>), FloatComparisonMode.OrderedEqualNonSignaling));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vxor1(in Vec256<double> x)
            => Xor(x.ymm, Compare(default(Vector256<double>), default(Vector256<double>), FloatComparisonMode.OrderedEqualNonSignaling));


  
   }

}