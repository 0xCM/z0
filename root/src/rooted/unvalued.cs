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
        /// Returns the null value for a nullable value type
        /// </summary>
        /// <typeparam name="T">The nullable value type</typeparam>
        [MethodImpl(Inline)]
        public static T? unvalued<T>()
            where T : struct
                => (T?)null;
    }
}