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
        public static Vec128<sbyte> vxnor(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vxnor(in Vec128<byte> x, in Vec128<byte> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vxnor(in Vec128<short> x, in Vec128<short> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vxnor(in Vec128<ushort> x, in Vec128<ushort> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vxnor(in Vec128<int> x, in Vec128<int> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vxnor(in Vec128<uint> x, in Vec128<uint> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vxnor(in Vec128<long> x, in Vec128<long> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vxnor(in Vec128<ulong> x, in Vec128<ulong> y)
            => vnot(Xor(x.xmm, y.xmm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vxnor(in Vec256<byte> x, in Vec256<byte> y)
            => vnot(Xor(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vxnor(in Vec256<short> x, in Vec256<short> y)
            => vnot(Xor(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vxnor(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => vnot(Xor(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vxnor(in Vec256<ushort> x, in Vec256<ushort> y)
            => vnot(Xor(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vxnor(in Vec256<int> x, in Vec256<int> y)
            => vnot(Xor(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vxnor(in Vec256<uint> x, in Vec256<uint> y)
            => vnot(Xor(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vxnor(in Vec256<long> x, in Vec256<long> y)
            => vnot(Xor(x.ymm, y.ymm));

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vxnor(in Vec256<ulong> x, in Vec256<ulong> y)
            => vnot(Xor(x.ymm, y.ymm));
   }

}