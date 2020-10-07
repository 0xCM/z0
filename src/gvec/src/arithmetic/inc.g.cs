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
    using static z;

    partial class gvec
    {
        /// <summary>
        /// Increments each component by unit value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Inc, Closures(Integers)]
        public static Vector128<T> vinc<T>(Vector128<T> src)
            where T : unmanaged
                => vinc_u(src);

        /// <summary>
        /// Increments each component by unit value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Inc, Closures(Integers)]
        public static Vector256<T> vinc<T>(Vector256<T> src)
            where T : unmanaged
                => vinc_u(src);

        /// <summary>
        /// Creates a 128-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Inc, Closures(Integers)]
        public static Vector128<T> vinc<T>(N128 n, T x0)
            where T : unmanaged
                => vadd(z.vinc<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Inc, Closures(Integers)]
        public static Vector256<T> vinc<T>(N256 n, T x0)
            where T : unmanaged
                => vadd(z.vinc<T>(n), x0);

        /// <summary>
        /// Creates a 256-bit vector with components that increase by unit step from an initial value
        /// </summary>
        /// <param name="x0">The value of the first component</param>
        /// <param name="step">The distance between adjacent components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vinc<T>(W512 w, T x0)
            where T : unmanaged
                => vadd(z.vinc<T>(w), x0);

        [MethodImpl(Inline)]
        static Vector128<T> vinc_u<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(z.vinc(v8u(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(z.vinc(v16u(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(z.vinc(v32u(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(z.vinc(v64u(src)));
            else
                return vinc_i(src);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vinc_i<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(z.vinc(v8i(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(z.vinc(v16i(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(z.vinc(v32i(src)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(z.vinc(v64i(src)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinc_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(z.vinc(v8u(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(z.vinc(v16u(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(z.vinc(v32u(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(z.vinc(v64u(src)));
            else
                return vinc_i(src);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinc_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(z.vinc(v8i(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(z.vinc(v16i(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(z.vinc(v32i(src)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(z.vinc(v64i(src)));
            else
                throw no<T>();
        }
    }
}