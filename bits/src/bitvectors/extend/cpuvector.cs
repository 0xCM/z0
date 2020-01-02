//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static partial class BitVectorX
    {
        /// <summary>
        /// Extracts a 128-bit cpu vector from a bitsring of sufficient length
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="w">The bit width selector</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The target vectror component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> ToCpuVector<T>(this BitString src, N128 w, T t = default)
            where T : unmanaged   
                => src.Pack().As<byte, T>().Blocked(w).LoadVector();

        /// <summary>
        /// Extracts a 256-bit cpu vector from a bitsring of sufficient length
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="w">The bit width selector</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The target vectror component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> ToCpuVector<T>(this BitString src, N256 w, T t = default)
            where T : unmanaged
                => src.Pack().As<byte, T>().Blocked(w).LoadVector();
    }
}
