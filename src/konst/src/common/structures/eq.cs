//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Structures
    {
        /// <summary>
        /// Determines whether each corresponding bytes of two structural values are identical
        /// </summary>
        /// <param name="x">The first value</param>
        /// <param name="y">The second value</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool eq<T>(in T x, in T y)
            where T : struct
        {
            var count = (uint)size<T>();
            ref readonly var bx = ref @as<T,byte>(x);
            ref readonly var by = ref @as<T,byte>(y);

            for(var i=0; i<count; i++)
                if(skip(bx,i) != skip(by,i))
                    return false;
            return true;
        }       
    }
}