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
        /// Operator factory for vadd_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VaddOp128<T> vadd<T>(N128 w, T t = default)
            where T : unmanaged
                => VaddOp128<T>.Op;

        /// <summary>
        /// Operator factory for vadd_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VaddOp256<T> vadd<T>(N256 w, T t = default)
            where T : unmanaged
                => VaddOp256<T>.Op;

        /// <summary>
        /// Operator factory for vsub_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsubOp128<T> vsub<T>(N128 w, T t = default)
            where T : unmanaged
                => VsubOp128<T>.Op;

        /// <summary>
        /// Operator factory for vsub_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VsubOp256<T> vsub<T>(N256 w, T t = default)
            where T : unmanaged            
                => VsubOp256<T>.Op;

        /// <summary>
        /// Operator factory for vnegate_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnegateOp128<T> vnegate<T>(N128 w, T t = default)
            where T : unmanaged
                => VnegateOp128<T>.Op;

        /// <summary>
        /// Operator factory for vnegate_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VnegateOp256<T> vnegate<T>(N256 w, T t = default)
            where T : unmanaged
                => VnegateOp256<T>.Op;

        /// <summary>
        /// Operator factory for vinc_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VincOp128<T> vinc<T>(N128 w, T t = default)
            where T : unmanaged
                => VincOp128<T>.Op;

        /// <summary>
        /// Operator factory for vinc_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VincOp256<T> vinc<T>(N256 w, T t = default)
            where T : unmanaged
                => VincOp256<T>.Op;

        /// <summary>
        /// Operator factory for vdec_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VdecOp128<T> vdec<T>(N128 w, T t = default)
            where T : unmanaged
                => VdecOp128<T>.Op;

        /// <summary>
        /// Operator factory for vdec_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VdecOp256<T> vdec<T>(N256 w, T t = default)
            where T : unmanaged
                => VdecOp256<T>.Op;

        /// <summary>
        /// Operator factory for vabs_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VabsOp128<T> vabs<T>(N128 w, T t = default)
            where T : unmanaged
                => VabsOp128<T>.Op;

        /// <summary>
        /// Operator factory for vabs_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VabsOp256<T> vabs<T>(N256 w, T t = default)
            where T : unmanaged
                => VabsOp256<T>.Op;


    }

}