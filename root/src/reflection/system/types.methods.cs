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

    using static ReflectionFlags;
    using static Root;

    partial class RootReflections
    {
        /// <summary>
        /// Selects the first method found on the type, if any, that has a specified name
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name to match</param>
        public static Option<MethodInfo> Method(this Type src, string name)
            => src.DeclaredMethods().WithName(name).FirstOrDefault();

        /// <summary>
        /// Retrieves a type's default constructor, if present; otherwise, none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ConstructorInfo> DefaultConstructor(this Type t)
            => t.GetConstructor(BF_DeclaredInstance, null, new Type[] { }, new ParameterModifier[] { });
    }
}