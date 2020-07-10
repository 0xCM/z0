//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Linq;

    using static Part;

    partial class XTend
    {
        /// <summary>
        /// Linq where operator specialized for arrays
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f"></param>
        /// <typeparam name="T">The array element type</typeparam>        
        [MethodImpl(Inline)]
        public static T[] Where<T>(this T[] src, Func<T,bool> f)
            => where(src,f);

        /// <summary>
        /// Result = Filter + Project
        /// </summary>
        /// <param name="src"></param>
        /// <param name="test"></param>
        /// <param name="project"></param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static T[] Where<S,T>(this S[] src, Func<S,bool> test, Func<S,T> project)
            => map(where(src,test), project);
   }
}