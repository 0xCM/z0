//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    partial class XTend
    {
        /// <summary>
        /// Returns the underlying system type if enclosed by a source type, otherwise returns the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static Type Unwrap(this Type src)
            => src.GetElementType() ?? src;
    }
}