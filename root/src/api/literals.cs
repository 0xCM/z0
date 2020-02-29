//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {
        /// <summary>
        /// Returns generic 0 for a primal source type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T zero<T>(T t = default)
            where T : unmanaged
                => Literals.zero<T>();

        /// <summary>
        /// Returns generic 1 for a primal source type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T one<T>(T t = default)
            where T : unmanaged
                => Literals.one<T>();

        /// <summary>
        /// Ones all bits each and every ... one
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T ones<T>(T t = default)
            where T : unmanaged
                => Literals.ones<T>();

        /// <summary>
        /// Returns the minimum value for a primal source type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : unmanaged
                => Literals.minval<T>();

        /// <summary>
        /// Returns the maximum value for a primal source type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
                => Literals.maxval<T>();
    }
}