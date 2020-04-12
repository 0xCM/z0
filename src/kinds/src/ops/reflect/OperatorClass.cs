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
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsOperator(this MethodInfo src)
            => ClassifiedOps.IsOperator(src);

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsHomogenous(this MethodInfo src)
            => ClassifiedOps.IsHomogenous(src);

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static OperatorClass ClassifyOperator(this MethodInfo src)
            => ClassifiedOps.ClassifyOperator(src);

        /// <summary>
        /// Queries the stream for methods with a nonempty operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithOperatorClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyOperator() != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithOperatorClass(this IEnumerable<MethodInfo> src, OperatorClass @class)
            => from m in src where m.ClassifyOperator() == @class select m;
    }
}