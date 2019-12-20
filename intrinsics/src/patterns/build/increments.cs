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
    using static ginx;
    using static As;

    partial class CpuVector
    {
        /// <summary>
        /// Creates a 128-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="n">The vector bit-width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> increments<T>(N128 n)
            where T : unmanaged
                => VData.increments<T>(n);

        /// <summary>
        /// Creates a 256-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="n">The vector bit-width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> increments<T>(N256 n)
            where T : unmanaged
                => VData.increments<T>(n);

        /// <summary>
        /// Creates a 512-bit vector with component values 0, 1, ... k - 1 where k is the length of the target vector
        /// </summary>
        /// <param name="n">The vector bit-width selector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> increments<T>(N512 n)
            where T : unmanaged
                => VData.increments<T>(n);

        /// <summary>
        /// Creates a 128-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> increments<T>(N128 n, T x0)
            where T : unmanaged
                => vadd(increments<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> increments<T>(N256 n, T x0)
            where T : unmanaged
                => vadd(increments<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> increments<T>(N512 n, T x0)
            where T : unmanaged
                => vadd(increments<T>(n), x0);

    }

}