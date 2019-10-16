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
        public static Vec128<sbyte> vxor(in Vec128<sbyte> x, in Vec128<sbyte> y)
            => Xor(x.xmm, y.xmm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vxor(in Vec128<byte> x, in Vec128<byte> y)
            => Xor(x.xmm, y.xmm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vxor(in Vec128<short> x, in Vec128<short> y)
            => Xor(x.xmm, y.xmm);


        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vxor(in Vec128<ushort> x, in Vec128<ushort> y)
            => Xor(x.xmm, y.xmm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vxor(in Vec128<int> x, in Vec128<int> y)
            => Xor(x.xmm, y.xmm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vxor(in Vec128<uint> x, in Vec128<uint> y)
            => Xor(x.xmm, y.xmm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vxor(in Vec128<long> x, in Vec128<long> y)
            => Xor(x.xmm, y.xmm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vxor(in Vec128<ulong> x, in Vec128<ulong> y)
            => Xor(x.xmm, y.xmm);


        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vxor(in Vec256<byte> x, in Vec256<byte> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vxor(in Vec256<short> x, in Vec256<short> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vxor(in Vec256<sbyte> x, in Vec256<sbyte> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vxor(in Vec256<ushort> x, in Vec256<ushort> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vxor(in Vec256<int> x, in Vec256<int> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vxor(in Vec256<uint> x, in Vec256<uint> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vxor(in Vec256<long> x, in Vec256<long> y)
            => Xor(x.ymm, y.ymm);

        /// <summary>
        /// Computes the bitwise XOR between operands
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vxor(in Vec256<ulong> x, in Vec256<ulong> y)
            => Xor(x.ymm, y.ymm);


   }

}