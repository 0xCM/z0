//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        /// <summary>
        /// Returns the index of the first value that matches a specified value, if any. Otherwise, returns -1
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="value">The value to match in the source</param>
        /// <typeparam name="T">The element type</typeparam>
        public static int FirstIndexOf<T>(this T[] src, T value)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i].Equals(value))
                    return i;
            return -1;
        }
    }
}