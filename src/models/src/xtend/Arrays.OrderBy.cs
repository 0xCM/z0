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
        /// Linq orderby operator specialized for arrays
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The order criterion selector</param>
        /// <typeparam name="T">The array element type</typeparam>
        /// <typeparam name="K">The order criterion type</typeparam>
        [MethodImpl(Inline)]
        public static T[] OrderBy<T,K>(this T[] src, Func<T,K> f)
            => Enumerable.OrderBy(src,f).ToArray();
    }
}