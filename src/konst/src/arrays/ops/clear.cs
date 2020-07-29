//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct Arrays
    {            
        /// <summary>
        /// Fills an array with the element type's default value
        /// </summary>
        /// <param name="dst">The source array</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] clear<T>(T[] dst)
            where T : struct
        {
            if(dst != null)
                Array.Fill(dst, default(T));
            return dst;
        }
    }
}