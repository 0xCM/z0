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
        /// Operator factory for vand_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static And128<T> vand<T>(N128 w, T t = default)
            where T : unmanaged
                => And128<T>.Op;

        /// <summary>
        /// Operator factory for vand_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static And256<T> vand<T>(N256 w, T t = default)
            where T : unmanaged
                => And256<T>.Op;

        /// <summary>
        /// Operator factory for vor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Or128<T> vor<T>(N128 w, T t = default)
            where T : unmanaged
                => Or128<T>.Op;

        /// <summary>
        /// Operator factory for vor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Or256<T> vor<T>(N256 w, T t = default)
            where T : unmanaged
                => Or256<T>.Op;

        /// <summary>
        /// Operator factory for vxor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Xor128<T> vxor<T>(N128 w, T t = default)
            where T : unmanaged
                => Xor128<T>.Op;

        /// <summary>
        /// Operator factory for vxor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Xor256<T> vxor<T>(N256 w, T t = default)
            where T : unmanaged
                => Xor256<T>.Op;

        /// <summary>
        /// Operator factory for vnand_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Nand128<T> vnand<T>(N128 w, T t = default)
            where T : unmanaged
                => Nand128<T>.Op;

        /// <summary>
        /// Operator factory for vnand_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Nand256<T> vnand<T>(N256 w, T t = default)
            where T : unmanaged
                => Nand256<T>.Op;

        /// <summary>
        /// Operator factory for vnor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Nor128<T> vnor<T>(N128 w, T t = default)
            where T : unmanaged
                => Nor128<T>.Op;

        /// <summary>
        /// Operator factory for vnor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Nor256<T> vnor<T>(N256 w, T t = default)
            where T : unmanaged
                => Nor256<T>.Op;

        /// <summary>
        /// Operator factory for vxnor_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Xnor128<T> vxnor<T>(N128 w, T t = default)
            where T : unmanaged
                => Xnor128<T>.Op;

        /// <summary>
        /// Operator factory for vxnor_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Xnor256<T> vxnor<T>(N256 w, T t = default)
            where T : unmanaged
                => Xnor256<T>.Op;

        /// <summary>
        /// Operator factory for vxornot_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static XorNot128<T> vxornot<T>(N128 w, T t = default)
            where T : unmanaged
                => XorNot128<T>.Op;

        /// <summary>
        /// Operator factory for vxornot_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static XorNot256<T> vxornot<T>(N256 w, T t = default)
            where T : unmanaged
                => XorNot256<T>.Op;

        /// <summary>
        /// Operator factory for vnot_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Not128<T> vnot<T>(N128 w, T t = default)
            where T : unmanaged
                => Not128<T>.Op;

        /// <summary>
        /// Operator factory for vnot_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Not256<T> vnot<T>(N256 w, T t = default)
            where T : unmanaged
                => Not256<T>.Op;

        /// <summary>
        /// Operator factory for vselect_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Select128<T> vselect<T>(N128 w, T t = default)
            where T : unmanaged
                => Select128<T>.Op;

        /// <summary>
        /// Operator factory for vselect_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Select256<T> vselect<T>(N256 w, T t = default)
            where T : unmanaged
                => Select256<T>.Op;
   }
}