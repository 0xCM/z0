//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    
    partial class XTend
    {
        /// <summary>
        /// Populates a target array by casting each elements of a source aray to the target element type
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static T[] Cast<T>(this object[] src)
        {
            var dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = (T)src[i];
            return dst;
        }
    }
}