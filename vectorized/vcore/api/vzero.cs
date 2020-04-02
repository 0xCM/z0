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

    using static Core;

    partial class VCore
    {
       /// <summary>
        /// Returns a 128-bit vector with all bits disabled
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vzero<T>(N128 w, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Returns a 256-bit vector with all bits disabled
        /// </summary>
        /// <param name="w">The bitness selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> vzero<T>(N256 w, T t = default)
            where T : unmanaged
                => default;
    }
}