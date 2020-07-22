//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
 
    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Selects all methods available through the type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] Methods(this Type src)
            => src.GetMethods(BF_World);
    }
}