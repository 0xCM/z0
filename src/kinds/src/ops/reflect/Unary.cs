//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryFunction(this MethodInfo m)
            => m.IsFunction() && m.HasArityValue(1);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOperator(this MethodInfo m)
            => m.IsHomogenous() && m.IsUnaryFunction();

        /// <summary>
        /// Selects unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOperators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsUnaryOperator());

    }
}