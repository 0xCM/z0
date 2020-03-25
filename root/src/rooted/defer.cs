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

    partial class Root
    {
        /// <summary>
        /// Creates a deferred value
        /// </summary>
        /// <param name="factory">A function that produces a value upon demeand</param>
        [MethodImpl(Inline)]
        public static Lazy<T> defer<T>(Func<T> factory)
            => new Lazy<T>(factory);
    }
}