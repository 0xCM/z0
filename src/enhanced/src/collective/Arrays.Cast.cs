//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    
    partial class XTend
    {
        /// <summary>
        /// Populates a target array by casting each elements of a source aray to the target element type
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static T[] Cast<T>(this object[] src)
            => cast<T>(src);

        // [MethodImpl(Inline)]
        // static T cast<T>(object src)
        //     => (T)src;

        [MethodImpl(Inline)]
        static T[] cast<T>(object[] src)
        {
            var dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = cast<T>(src[i]);
            return dst;
        }
    }
}