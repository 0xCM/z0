//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static Seed;
    using static Memories;
    using static dvec;

    partial class VBits
    {
        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> bitblend<T>(Vector128<T> x, Vector128<T> y, Vector128<T> mask)
            where T : unmanaged
                => gvec.vxor(x, gvec.vand(gvec.vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> bitblend<T>(Vector256<T> x, Vector256<T> y, Vector256<T> mask)
            where T : unmanaged
                => gvec.vxor(x, gvec.vand(gvec.vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> bitblend(Vector128<byte> x, Vector128<byte> y, Vector128<byte> mask) 
            => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> bitblend(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> mask) 
            => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> bitblend(Vector128<uint> x, Vector128<uint> y, Vector128<uint> mask) 
            => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> bitblend(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> mask) 
            => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> bitblend(Vector256<byte> x, Vector256<byte> y, Vector256<byte> mask) 
            => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> bitblend(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> mask) 
            => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> bitblend(Vector256<uint> x, Vector256<uint> y, Vector256<uint> mask) 
            => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> bitblend(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> mask) 
            => vxor(x, vand(vxor(x,y), mask));        
    }
}