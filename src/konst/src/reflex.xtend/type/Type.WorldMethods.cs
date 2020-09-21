//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// All of the methods belong to us
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] WorldMethods(this Type src)
            => src.GetMethods(BF_World);
    }
}