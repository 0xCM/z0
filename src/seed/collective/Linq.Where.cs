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
        /// (LInQ Hijack) Filters the source array with a specified predicate
        /// </summary>
        /// <param name="src"></param>
        /// <param name="f"></param>
        /// <typeparam name="T"></typeparam>
        public static T[] Where<T>(this T[] src, Func<T,bool> f)
            => Control.filter(src,f);

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