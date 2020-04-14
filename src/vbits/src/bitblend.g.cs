//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Seed;
    using static Memories;
    using static gvec;

    partial class vgbits
    {
        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vbitblend<T>(Vector128<T> x, Vector128<T> y, Vector128<T> mask)
            where T : unmanaged
                => vxor(x, vand(vxor(x,y), mask));

        /// <summary>
        /// Blends the left and right vectors at the bit-level as specified by the mask operand.
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="mask">The selection mask</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <remarks>Equivalent to select</remarks>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vbitblend<T>(Vector256<T> x, Vector256<T> y, Vector256<T> mask)
            where T : unmanaged
                => vxor(x, vand(vxor(x,y), mask));
    }
}