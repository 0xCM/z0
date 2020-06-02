//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        /// <summary>
        /// Returns the maximum value supported by a parametrically-identified primal type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T maxval<T>()
            where T : unmanaged
                => Literals.maxval<T>();

        [MethodImpl(Inline)]
        public static T maxval<T>(T rep)
            where T : unmanaged
                => maxval<T>();

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T max<T>(NK<T> nk)
            where T : unmanaged
                => maxval<T>();

    }
}