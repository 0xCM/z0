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

    using static Seed;
    
    partial class XTend
    {
        /// <summary>
        /// Linq where operator specialized for arrays
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f"></param>
        /// <typeparam name="T">The array element type</typeparam>
        public static T[] Where<T>(this T[] src, Func<T,bool> f)
            => Control.filter(src,f);

        /// <summary>
        /// Linq orderby operator specialized for arrays
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The order criterion selector</param>
        /// <typeparam name="T">The array element type</typeparam>
        /// <typeparam name="K">The order criterion type</typeparam>
        public static T[] OrderBy<T,K>(this T[] src, Func<T,K> f)
            => Enumerable.OrderBy(src,f).ToArray();

        /// <summary>
        /// Result = Filter + Project
        /// </summary>
        /// <param name="src"></param>
        /// <param name="test"></param>
        /// <param name="project"></param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static T[] Where<S,T>(this S[] src, Func<S,bool> test, Func<S,T> project)
            => Control.map(Control.filter(src,test), project);
    }
}