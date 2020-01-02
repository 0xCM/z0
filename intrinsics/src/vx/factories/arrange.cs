//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Operator factory for vconcat_2x128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Concat2x128<T> vconcat<T>(N128 w, T t = default)
            where T : unmanaged
                => Concat2x128<T>.Op;

        /// <summary>
        /// Operator factory for vconcat_2x128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Broadcast128<T> vbroadcast<T>(N128 w, T t = default)
            where T : unmanaged
                => Broadcast128<T>.Op;

        /// <summary>
        /// Operator factory for vconcat_2x128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Broadcast128<S,T> vbroadcast<S,T>(N128 w, S s = default, T t = default)
            where T : unmanaged        
            where S : unmanaged
                => Broadcast128<S,T>.Op;

        /// <summary>
        /// Operator factory for vconcat_2x128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Broadcast256<T> vbroadcast<T>(N256 w, T t = default)
            where T : unmanaged
                => Broadcast256<T>.Op;

        /// <summary>
        /// Operator factory for vconcat_2x128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Broadcast256<S,T> vbroadcast<S,T>(N256 w, S s = default, T t = default)
            where T : unmanaged        
            where S : unmanaged
                => Broadcast256<S,T>.Op;

        /// <summary>
        /// Operator factory for vbyteswap_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSwap128<T> vbyteswap<T>(N128 w, T t = default)
            where T : unmanaged
                => ByteSwap128<T>.Op;

        /// <summary>
        /// Operator factory for vbyteswap_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSwap256<T> vbyteswap<T>(N256 w, T t = default)
            where T : unmanaged
                => ByteSwap256<T>.Op;

        /// <summary>
        /// Operator factory for vhi_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Hi128<T> vhi<T>(N128 w, T t = default)
            where T : unmanaged
                => Hi128<T>.Op;

        /// <summary>
        /// Operator factory for vhi_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Hi256<T> vhi<T>(N256 w, T t = default)
            where T : unmanaged
                => Hi256<T>.Op;

        /// <summary>
        /// Operator factory for vlo_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Lo128<T> vlo<T>(N128 w, T t = default)
            where T : unmanaged
                => Lo128<T>.Op;

        /// <summary>
        /// Operator factory for vlo_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Lo256<T> vlo<T>(N256 w, T t = default)
            where T : unmanaged
                => Lo256<T>.Op;
    }
}