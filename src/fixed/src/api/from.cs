//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class Fixed
    {
        /// <summary>
        /// Presents a 128-bit vector as a 128-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly FixedCell128 from<T>(in Vector128<T> src)
            where T : unmanaged
                => ref from<Vector128<T>,FixedCell128>(in src);

        /// <summary>
        /// Presents a 256-bit vector as a 256-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly FixedCell256 from<T>(in Vector256<T> src)
            where T : unmanaged
                => ref from<Vector256<T>,FixedCell256>(in src);

        /// <summary>
        /// Presents a 512-bit vector as a 512-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly FixedCell512 from<T>(in Vector512<T> src)
            where T : unmanaged
                => ref from<Vector512<T>,FixedCell512>(in src);
    }
}