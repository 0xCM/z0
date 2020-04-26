//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Reflective
    {
        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool HasDefaultPublicConstructor(this Type t)
            => t.GetConstructor(new Type[] { }) != null;

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <typeparam name="T">The type to examine</typeparam>
        [MethodImpl(Inline)]
        public static bool HasDefaultPublicConstructor<T>()
            where T : class 
                => typeof(T).GetConstructor(new Type[] { }) != null; 
    }
}