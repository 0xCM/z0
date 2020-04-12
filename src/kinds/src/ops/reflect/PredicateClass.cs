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
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsPredicate(this MethodInfo src)        
            => ClassifiedOps.IsPredicate(src);

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static PredicateClass ClassifyPredicate(this MethodInfo src)
            => ClassifiedOps.ClassifyPredicate(src);

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