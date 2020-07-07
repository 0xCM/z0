//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Selects the mmutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Mutable(this FieldInfo[] src)
            => src.Where(x => !(x.IsInitOnly || x.IsLiteral));

        /// <summary>
        /// Selects the immutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Immutable(this FieldInfo[] src)
            => src.Where(x => x.IsInitOnly || x.IsLiteral);
    }
}