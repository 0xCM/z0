//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static VOpTypes;

    partial class VOps
    {
        /// <summary>
        /// Operator factory for veq_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Eq128<T> veq<T>(N128 w, T t = default)
            where T : unmanaged
                => Eq128<T>.Op;

        /// <summary>
        /// Operator factory for veq_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Eq256<T> veq<T>(N256 w, T t = default)
            where T : unmanaged
                => Eq256<T>.Op;

        /// <summary>
        /// Operator factory for vlt_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Lt128<T> vlt<T>(N128 w, T t = default)
            where T : unmanaged
                => Lt128<T>.Op;

        /// <summary>
        /// Operator factory for vlt_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Lt256<T> vlt<T>(N256 w, T t = default)
            where T : unmanaged
                => Lt256<T>.Op;

        /// <summary>
        /// Operator factory for vgt_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Gt128<T> vgt<T>(N128 w, T t = default)
            where T : unmanaged
                => Gt128<T>.Op;

        /// <summary>
        /// Operator factory for vgt_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Gt256<T> vgt<T>(N256 w, T t = default)
            where T : unmanaged
                => Gt256<T>.Op;
 
        /// <summary>
        /// Operator factory for vmax_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Max128<T> vmax<T>(N128 w, T t = default)
            where T : unmanaged
                => Max128<T>.Op;

        /// <summary>
        /// Operator factory for vmax_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Max256<T> vmax<T>(N256 w, T t = default)
            where T : unmanaged
                => Max256<T>.Op;

        /// <summary>
        /// Operator factory for vmin_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Min128<T> vmin<T>(N128 w, T t = default)
            where T : unmanaged
                => Min128<T>.Op;

        /// <summary>
        /// Operator factory for vmin_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Min256<T> vmin<T>(N256 w, T t = default)
            where T : unmanaged
                => Min256<T>.Op;

        /// <summary>
        /// Operator factory for vnonz_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Nonz128<T> vnonz<T>(N128 w, T t = default)
            where T : unmanaged
                => Nonz128<T>.Op;

        /// <summary>
        /// Operator factory for vnonz_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Nonz256<T> vnonz<T>(N256 w, T t = default)
            where T : unmanaged
                => Nonz256<T>.Op;

        /// <summary>
        /// Operator factory for vtestc_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Testc128<T> vtestc<T>(N128 w, T t = default)
            where T : unmanaged
                => Testc128<T>.Op;

        /// <summary>
        /// Operator factory for vtestc_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Testc256<T> vtestc<T>(N256 w, T t = default)
            where T : unmanaged
                => Testc256<T>.Op;

        /// <summary>
        /// Operator factory for vtestz_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Testz128<T> vtestz<T>(N128 w, T t = default)
            where T : unmanaged
                => Testz128<T>.Op;

        /// <summary>
        /// Operator factory for vtestz_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Testz256<T> vtestz<T>(N256 w, T t = default)
            where T : unmanaged
                => Testz256<T>.Op;
    }
}