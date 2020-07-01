//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct As
    {         
        /// <summary>
        /// The canonical swap function, sort of
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void swap<T>(in T lhs, in T rhs)
        {
            var temp = lhs;
            edit(lhs) = rhs;
            edit(rhs) = temp;
        }
    }
}