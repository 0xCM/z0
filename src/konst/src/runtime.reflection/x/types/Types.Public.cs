//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    partial class XTend
    {
        /// <summary>
        /// Selects the public types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static Type[] Public(this Type[] src)
            => src.Where(t => t.IsPublic);
    }
}