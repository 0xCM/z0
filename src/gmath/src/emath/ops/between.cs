//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct emath
    {
       /// <summary>
        /// Determines whether an integral value is greater or equal to a value represented by an enum literal
        /// </summary>
        /// <param name="e">The enum literal value</param>
        /// <param name="s">The scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static bit between<E,T>(T s, E e0, E e1)
            where E : unmanaged, Enum
            where T : unmanaged
                => gmath.between(s, @as<E,T>(e0), @as<E,T>(e1));
    }
}