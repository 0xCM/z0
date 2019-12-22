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
    
    using static zfunc;    

    partial class CpuVector
    {
        /// <summary>
        /// Creates a 128-bit zero-filled vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> zero<T>(N128 w, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates a 256-bit zero-filled vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> zero<T>(N256 w, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates a 512-bit zero-filled vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> zero<T>(N512 w, T t = default)
            where T : unmanaged
                => default;
    }

}