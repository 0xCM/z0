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
        /// Determines whether the type is a (memory) reference
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsRef(this Type src)
            => src.UnderlyingSystemType.IsByRef;
    }
}