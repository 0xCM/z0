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
        public static VeqOp128<T> veq<T>(N128 w, T t = default)
            where T : unmanaged
                => VeqOp128<T>.Op;

        /// <summary>
        /// Operator factory for veq_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VeqOp256<T> veq<T>(N256 w, T t = default)
            where T : unmanaged
                => VeqOp256<T>.Op;

        /// <summary>
        /// Operator factory for vlt_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VltOp128<T> vlt<T>(N128 w, T t = default)
            where T : unmanaged
                => VltOp128<T>.Op;

        /// <summary>
        /// Operator factory for vlt_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VltOp256<T> vlt<T>(N256 w, T t = default)
            where T : unmanaged
                => VltOp256<T>.Op;

        /// <summary>
        /// Operator factory for vgt_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VgtOp128<T> vgt<T>(N128 w, T t = default)
            where T : unmanaged
                => VgtOp128<T>.Op;

        /// <summary>
        /// Operator factory for vgt_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VgtOp256<T> vgt<T>(N256 w, T t = default)
            where T : unmanaged
                => VgtOp256<T>.Op;
 
        /// <summary>
        /// Operator factory for vmax_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VmaxOp128<T> vmax<T>(N128 w, T t = default)
            where T : unmanaged
                => VmaxOp128<T>.Op;

        /// <summary>
        /// Operator factory for vmax_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VmaxOp256<T> vmax<T>(N256 w, T t = default)
            where T : unmanaged
                => VmaxOp256<T>.Op;

        /// <summary>
        /// Operator factory for vmin_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VminOp128<T> vmin<T>(N128 w, T t = default)
            where T : unmanaged
                => VminOp128<T>.Op;

        /// <summary>
        /// Operator factory for vmin_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VminOp256<T> vmin<T>(N256 w, T t = default)
            where T : unmanaged
                => VminOp256<T>.Op;

        /// <summary>
        /// Operator factory for vnonz_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnonzOp128<T> vnonz<T>(N128 w, T t = default)
            where T : unmanaged
                => VnonzOp128<T>.Op;

        /// <summary>
        /// Operator factory for vnonz_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnonzOp256<T> vnonz<T>(N256 w, T t = default)
            where T : unmanaged
                => VnonzOp256<T>.Op;

        /// <summary>
        /// Operator factory for vtestc_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VtestcOp128<T> vtestc<T>(N128 w, T t = default)
            where T : unmanaged
                => VtestcOp128<T>.Op;

        /// <summary>
        /// Operator factory for vtestc_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VtestcOp256<T> vtestc<T>(N256 w, T t = default)
            where T : unmanaged
                => VtestcOp256<T>.Op;

        /// <summary>
        /// Operator factory for vtestz_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VtestzOp128<T> vtestz<T>(N128 w, T t = default)
            where T : unmanaged
                => VtestzOp128<T>.Op;

        /// <summary>
        /// Operator factory for vtestz_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VtestzOp256<T> vtestz<T>(N256 w, T t = default)
            where T : unmanaged
                => VtestzOp256<T>.Op;


    }

}