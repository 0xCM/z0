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
        public static Vec128<sbyte> vnor(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vnor(in Vec128<byte> x, in Vec128<byte> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vnor(in Vec128<short> x, in Vec128<short> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vnor(in Vec128<ushort> x, in Vec128<ushort> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vnor(in Vec128<int> x, in Vec128<int> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vnor(in Vec128<uint> x, in Vec128<uint> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vnor(in Vec128<long> x, in Vec128<long> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vnor(in Vec128<ulong> x, in Vec128<ulong> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<float> vnor(in Vec128<float> x, in Vec128<float> y)
            => vnot_d(Or(x.xmm, y.xmm));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vnor(in Vec128<double> x, in Vec128<double> y)
            => vnot_d(Or(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vnor(in Vec256<byte> x, in Vec256<byte> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vnor(in Vec256<short> x, in Vec256<short> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vnor(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vnor(in Vec256<ushort> x, in Vec256<ushort> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vnor(in Vec256<int> x, in Vec256<int> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vnor(in Vec256<uint> x, in Vec256<uint> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vnor(in Vec256<long> x, in Vec256<long> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vnor(in Vec256<ulong> x, in Vec256<ulong> y)
            => vnot_d(Or(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<float> vnor(in Vec256<float> x, in Vec256<float> y)
            => vnot_d(Or(x.ymm, y.ymm));
        
        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<double> vnor(in Vec256<double> x, in Vec256<double> y)
            => vnot_d(Or(x.ymm, y.ymm));

   }

}