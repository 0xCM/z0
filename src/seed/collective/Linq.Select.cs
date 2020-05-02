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
        /// (LInQ Hijack) Defines an array map synonym invoked in lieu of the system-defined Select operator
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        [MethodImpl(Inline)]
        public static T[] Select<S,T>(this S[] src, Func<S,T> f)
            => Control.map(src,f);        
    }
}