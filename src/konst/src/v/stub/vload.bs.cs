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
    using static Typed;
    using static z;

    partial struct V0
    {
        /// <summary>
        /// Loads a 128-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => generic<T>(V0.vload(n, in first(src)));

        /// <summary>
        /// Loads a 256-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => generic<T>(V0.vload(n, in first(src)));

        /// <summary>
        /// Loads a 512-bit pattern described by a readonly bytespan
        /// </summary>
        /// <param name="n">The vector width selector</param>
        /// <param name="src">The pattern data source</param>
        /// <typeparam name="T">The target vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vload<T>(N512 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => generic<T>(V0.vload(n, in first(src)));    
    }
}