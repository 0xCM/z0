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
    
    public static class ReflectedOperationClass
    {

        /// <summary>
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static ArityClass ClassifyArity(this MethodInfo m)
            => ClassifiedOperations.ArityClass(m);

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsHomogenous(this MethodInfo src)
            => ClassifiedOperations.IsHomogenous(src);

        /// <summary>
        /// Determines the numeric arity of a classified operator
        /// </summary>
        /// <param name="src">The operator class</param>
        public static int ArityValue(this OperatorClass src)
            => ClassifiedOperations.ArityValue(src);

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsOperator(this MethodInfo src)
            => ClassifiedOperations.IsOperator(src);

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static OperatorClass ClassifyOperator(this MethodInfo src)
            => ClassifiedOperations.ClassifyOperator(src);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsPredicate(this MethodInfo src)        
            => ClassifiedOperations.IsPredicate(src);

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static PredicateClass ClassifyPredicate(this MethodInfo src)
            => ClassifiedOperations.ClassifyPredicate(src);


        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Functions(this IEnumerable<MethodInfo> src)
            => src.Where(ClassifiedOperations.IsFunction);

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Actions(this IEnumerable<MethodInfo> src)
            => src.Where(ClassifiedOperations.IsAction);

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