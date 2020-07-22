//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Retrieves the public and non-public instance methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static MethodInfo[] InstanceMethods(this Type src)
            => src.GetMethods(BF_World);
    }
}