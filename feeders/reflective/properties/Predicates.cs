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
    
    partial class Reflections
    {
        public static bool IsStatic(this PropertyInfo p)
            => p.GetGetMethod()?.IsStatic == true 
            || p.GetSetMethod().IsStatic == true;

        /// <summary>
        /// Determines whether a property is an indexer
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool IsIndexer(this PropertyInfo p)
            => p.GetIndexParameters().Length > 0;

        /// <summary>
        /// Determines whether the property has a public or non-public setter
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool HasSetter(this PropertyInfo p)
            => p.GetSetMethod() != null;

        /// <summary>
        /// Determines whether the property has a public or non-public getter
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool HasGetter(this PropertyInfo p)
            => p.GetGetMethod() != null;
    }
}