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

    partial class Control
    {
        /// <summary>
        /// Hydrates a 128-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector128<T> vwrite<S,T>(W128 w, ref S src)
            where T : unmanaged
                => ref write<S,Vector128<T>>(ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector256<T> vwrite<S,T>(W256 w, ref S src)
            where T : unmanaged
                => ref write<S,Vector256<T>>(ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector512<T> vwrite<S,T>(W512 w, ref S src)
            where T : unmanaged
                => ref write<S,Vector512<T>>(ref src);
    }
}