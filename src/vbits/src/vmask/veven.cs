//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static Vectors;
    
    partial class VMask
    {
        /// <summary>
        /// [01010101] | [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> veven<F,D,T>(N128 w, F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(D) == typeof(N1))
                return veven(w,n2, n1, t);
            else if(typeof(D) == typeof(N2))
                return veven(w,n2, n2, t);
            else
                throw Unsupported.define<D>();
        }

        /// <summary>
        /// [01010101] | [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> veven<F,D,T>(N256 w, F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(D) == typeof(N1))
                return veven(w,n2, n1, t);
            else if(typeof(D) == typeof(N2))
                return veven(w,n2, n2, t);
            else
                throw Unsupported.define<D>();
        }

        /// <summary>
        /// [01010101]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static Vector128<T> veven<T>(N128 w, N2 f = default, N1 d = default, T t = default)
            where T : unmanaged
                => Vectors.vbroadcast(w,BitMask.even(f,d,t));
                
        /// <summary>
        /// [01010101]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static Vector256<T> veven<T>(N256 w, N2 f = default, N1 d = default, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.even(f,d,t));

        /// <summary>
        /// [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static Vector128<T> veven<T>(N128 w, N2 f = default, N2 d = default, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.even(f,d,t));

        /// <summary>
        /// [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static Vector256<T> veven<T>(N256 w, N2 f = default, N2 d = default, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.even(f,d,t));
    }
}