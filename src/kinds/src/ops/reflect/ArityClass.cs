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
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static ArityClass ClassifyArity(this MethodInfo m)
            => ClassifiedOps.ArityClass(m);

        /// <summary>
        /// Determines the numeric arity of a classified operator
        /// </summary>
        /// <param name="src">The operator class</param>
        public static int ArityValue(this OperatorClass src)
            => ClassifiedOps.ArityValue(src);

        /// <summary>
        /// Queries the stream for methods with a nonempty measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithArityClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyArity() != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithArityClass(this IEnumerable<MethodInfo> src, ArityClass @class)
            => from m in src where m.ClassifyArity() == @class select m;
    }
}