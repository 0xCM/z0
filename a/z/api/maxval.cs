//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class root
    {
        /// <summary>
        /// Returns the maximum value for a primal source type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
                => Literals.maxval<T>();

        /// <summary>
        /// Returns the maximum value for a primal source type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static T maxval<T>(T t)
            where T : unmanaged
                => Literals.maxval<T>();
    }
}