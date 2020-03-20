//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    
    public static class OpQueryPredicates
    {
        /// <summary>
        /// Dtermines whether a method has a void return
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => OperationClasses.IsAction(m);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => OperationClasses.IsFunction(m);

        /// <summary>
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static ArityClass ClassifyArity(this MethodInfo m)
            => OperationClasses.ArityClass(m);

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsHomogenous(this MethodInfo src)
            => OperationClasses.IsHomogenous(src);

        /// <summary>
        /// Determines the numeric arity of a classified operator
        /// </summary>
        /// <param name="src">The operator class</param>
        public static int ArityValue(this OperatorClass src)
            => OperationClasses.ArityValue(src);

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsOperator(this MethodInfo src)
            => OperationClasses.IsOperator(src);

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static OperatorClass ClassifyOperator(this MethodInfo src)
            => OperationClasses.ClassifyOperator(src);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsPredicate(this MethodInfo src)        
            => OperationClasses.IsPredicate(src);

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static PredicateClass ClassifyPredicate(this MethodInfo src)
            => OperationClasses.ClassifyPredicate(src);
    }
}