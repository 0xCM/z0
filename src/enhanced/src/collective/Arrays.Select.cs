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
        /// Defines an array-specific select operator
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        [MethodImpl(Inline)]
        public static T[] Select<S,T>(this S[] src, Func<S,T> f)
            => map(src,f);   

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        static T[] map<S,T>(IEnumerable<S> src, Func<S,T> f)
            => src.Select(item => f(item)).ToArray();
    }
}