//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Retrieves all properties declared by a by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static PropertyInfo[] DeclaredProperties(this Type src)
            => src.GetProperties(BF_All);
    }
}