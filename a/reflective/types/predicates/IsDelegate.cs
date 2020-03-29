//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether the specified type is a delegate type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsDelegate(this Type t)
            => t.IsSubclassOf(typeof(Delegate));

    }
}