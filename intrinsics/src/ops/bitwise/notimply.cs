//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
 
    using static zfunc;
    
    public static partial class dinx
    {                
        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vnotimply(Vector128<sbyte> x, Vector128<sbyte> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vnotimply(Vector128<byte> x, Vector128<byte> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vnotimply(Vector128<short> x, Vector128<short> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vnotimply(Vector128<ushort> x, Vector128<ushort> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vnotimply(Vector128<int> x, Vector128<int> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vnotimply(Vector128<uint> x, Vector128<uint> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vnotimply(Vector128<long> x, Vector128<long> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vnotimply(Vector128<ulong> x, Vector128<ulong> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vnotimply(Vector256<sbyte> x, Vector256<sbyte> y)
            => AndNot(x, y);
 
        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vnotimply(Vector256<byte> x, Vector256<byte> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vnotimply(Vector256<short> x, Vector256<short> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vnotimply(Vector256<ushort> x, Vector256<ushort> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vnotimply(Vector256<int> x, Vector256<int> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vnotimply(Vector256<uint> x, Vector256<uint> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vnotimply(Vector256<long> x, Vector256<long> y)
            => AndNot(x, y);

        /// <summary>
        /// Computes the material nomimplication, equivalent to the bitwise expression ~x & y for operands x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vnotimply(Vector256<ulong> x, Vector256<ulong> y)
            => AndNot(x, y);
    }
}