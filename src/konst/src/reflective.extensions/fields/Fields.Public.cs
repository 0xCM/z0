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
        /// Selects the public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Public(this FieldInfo[] src)
            => src.Where(x => x.IsPublic);

        /// <summary>
        /// Selects the non-public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] NonPublic(this FieldInfo[] src)
            => src.Where(x => !x.IsPublic);
    }
}