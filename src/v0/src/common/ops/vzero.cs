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
    using static As;

    partial struct V0
    {           
        /// <summary>
        /// Returns a 128-bit vector with all bits disabled
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        public static Vector128<T> vzero<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Returns a 256-bit vector with all bits disabled
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        public static Vector256<T> vzero<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Returns a 512-bit vector with all bits disabled
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(AllNumeric)]
        public static Vector512<T> vzero<T>(W512 w, T t = default)
            where T : unmanaged
                => default;
    }
}