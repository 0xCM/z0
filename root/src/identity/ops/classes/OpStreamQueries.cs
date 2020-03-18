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

    using static Root;
    
    public static class OpStreamQueries
    {
        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Functions(this IEnumerable<MethodInfo> src)
            => src.Where(OperationClasses.IsFunction);

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Actions(this IEnumerable<MethodInfo> src)
            => src.Where(OperationClasses.IsAction);

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

        /// <summary>
        /// Queries the stream for methods with a specified predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithPredicateClass(this IEnumerable<MethodInfo> src, PredicateClass @class)
            => from m in src where m.ClassifyPredicate() == @class select m;

        /// <summary>
        /// Queries the stream for methods with a nonempty predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithPredicateClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyPredicate() != 0 select m; 
    }
}