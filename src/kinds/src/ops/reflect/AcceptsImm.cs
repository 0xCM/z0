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

    partial class XTend
    {
        /// <summary>
        /// Determines whether a method defines a parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo m)        
            => m.GetParameters().Where(IsImmediate).Any();

        /// <summary>
        /// Determines whether a method defines an index-identified parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo m, int index)        
        {
            var parameters = m.GetParameters().ToArray();
            return parameters.Length > index && parameters[index].IsImmediate();
        }
    }
}