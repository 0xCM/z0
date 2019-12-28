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

    using static VXTypes;

    partial class VX
    {

        /// <summary>
        /// Operator factory for vadd_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Add128<T> vadd<T>(N128 w, T t = default)
            where T : unmanaged
                => Add128<T>.Op;

        /// <summary>
        /// Operator factory for vadd_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Add256<T> vadd<T>(N256 w, T t = default)
            where T : unmanaged
                => Add256<T>.Op;

        /// <summary>
        /// Operator factory for vsub_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Sub128<T> vsub<T>(N128 w, T t = default)
            where T : unmanaged
                => Sub128<T>.Op;

        /// <summary>
        /// Operator factory for vsub_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Sub256<T> vsub<T>(N256 w, T t = default)
            where T : unmanaged            
                => Sub256<T>.Op;

        /// <summary>
        /// Operator factory for vnegate_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Negate128<T> vnegate<T>(N128 w, T t = default)
            where T : unmanaged
                => Negate128<T>.Op;

        /// <summary>
        /// Operator factory for vnegate_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Negate256<T> vnegate<T>(N256 w, T t = default)
            where T : unmanaged
                => Negate256<T>.Op;

        /// <summary>
        /// Operator factory for vinc_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Inc128<T> vinc<T>(N128 w, T t = default)
            where T : unmanaged
                => Inc128<T>.Op;

        /// <summary>
        /// Operator factory for vinc_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Inc256<T> vinc<T>(N256 w, T t = default)
            where T : unmanaged
                => Inc256<T>.Op;

        /// <summary>
        /// Operator factory for vdec_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Dec128<T> vdec<T>(N128 w, T t = default)
            where T : unmanaged
                => Dec128<T>.Op;

        /// <summary>
        /// Operator factory for vdec_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Dec256<T> vdec<T>(N256 w, T t = default)
            where T : unmanaged
                => Dec256<T>.Op;

        /// <summary>
        /// Operator factory for vabs_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Abs128<T> vabs<T>(N128 w, T t = default)
            where T : unmanaged
                => Abs128<T>.Op;

        /// <summary>
        /// Operator factory for vabs_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Abs256<T> vabs<T>(N256 w, T t = default)
            where T : unmanaged
                => Abs256<T>.Op;
    }
}