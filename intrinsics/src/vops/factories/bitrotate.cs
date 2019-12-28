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
        /// Operator factory for vrotrx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotrx128<T> vrotrx<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotrx128<T>.Op;

        /// <summary>
        /// Operator factory for vrotrx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotrx256<T> vrotrx<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotrx256<T>.Op;

        /// <summary>
        /// Operator factory for vrotlx_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotlx128<T> vrotlx<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotlx128<T>.Op;

        /// <summary>
        /// Operator factory for vrotlx_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotlx256<T> vrotlx<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotlx256<T>.Op;

        /// <summary>
        /// Operator factory for vrotl_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotl128<T> vrotl<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotl128<T>.Op;

        /// <summary>
        /// Operator factory for vrotl_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotl256<T> vrotl<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotl256<T>.Op;

        /// <summary>
        /// Operator factory for vrotr_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotr128<T> vrotr<T>(N128 w, T t = default)
            where T : unmanaged
                => Rotr128<T>.Op;

        /// <summary>
        /// Operator factory for vrotr_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Rotr256<T> vrotr<T>(N256 w, T t = default)
            where T : unmanaged
                => Rotr256<T>.Op;
 
    }
}