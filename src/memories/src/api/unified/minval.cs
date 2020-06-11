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
        /// Returns the minimum value supported by a parametrically-identified primal type
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T minval<T>()
            where T : unmanaged
                => NumericLiterals.minval<T>();

        /// <summary>
        /// Returns the minimum value supported by a parametrically-identified primal type
        /// </summary>
        /// <param name="nk">The kind classifier</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T min<T>(NK<T> nk)
            where T : unmanaged
                => minval<T>();
    }
}