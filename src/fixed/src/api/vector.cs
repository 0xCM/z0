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
    using static Memories;

    partial class Fixed    
    {
        /// <summary>
        /// Loads a 128-bit vector from 128-bit storage block
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vector<T>(in Fixed128 src)
            where T : unmanaged
                => src.ToVector<T>();

        /// <summary>
        /// Loads a 256-bit vector from 256-bit storage block
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vector<T>(in Fixed256 src)
            where T : unmanaged
                => src.ToVector<T>();

        /// <summary>
        /// Loads a 512-bit vector from 512-bit storage block
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector512<T> vector<T>(in Fixed512 src)
            where T : unmanaged
                => src.ToVector<T>();
    }
}