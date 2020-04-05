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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Core;

    partial class VCore
    {
        /// <summary>
        /// Loads a 128-bit vector from a readonly memory reference
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vload<T>(N128 w, in T src)
            where T : unmanaged                    
                => vload(constptr(in src), out Vector128<T> _);

        /// <summary>
        /// Loads a 256-bit vector from a readonly memory reference
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vload<T>(N256 w, in T src)
            where T : unmanaged
                => vload(constptr(in src), out Vector256<T> _);

        /// <summary>
        /// Loads a 128-bit vector from a readonly memory reference
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ref Vector128<T> vload<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
                => ref vload(constptr(in src), out dst);

        /// <summary>
        /// Loads a 256-bit vector from the first 256 bits of the source
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => vload(w, in head(src));

        /// <summary>
        /// Loads a 128-bit vector from a pointer-identified memory location
        /// </summary>
        /// <param name="pSrc">The source memory location</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ref Vector128<T> vload<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
                => ref Vectors.vload(pSrc, out dst);

        /// <summary>
        /// Loads a 256-bit vector from a pointer-identified memory location
        /// </summary>
        /// <param name="pSrc">The source memory location</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ref Vector256<T> vload<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
                => ref Vectors.vload(pSrc, out dst);
    }
}