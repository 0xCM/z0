//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static ImmFunctionClass;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsImmediate(this ParameterInfo param)
            => param.Tagged<ImmAttribute>();

        /// <summary>
        /// Selects parameters from a method, if any, that acceptrequire an immediate value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<ParameterInfo> ImmParameters(this MethodInfo src)
            => from p in src.GetParameters()
                where p.IsImmediate()
                select p;

        /// <summary>
        /// Returns a method's immediate parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ImmParameterTypes(this MethodInfo src)
            => src.ImmParameters().Select(p => p.ParameterType);
    }
}