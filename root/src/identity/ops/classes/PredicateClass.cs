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
    
    using FC = FunctionClass;

    public enum PredicateClass : ulong
    {
        None = 0,
       
        /// <summary>
        /// Classifies a function as a unary predicate
        /// </summary>        
        UnaryPred = FC.UnaryPred,

        /// <summary>
        /// Classifies a function as a binary predicate
        /// </summary>        
        BinaryPred = FC.BinaryPred,

       /// <summary>
       /// Classifies a function as a ternary predicate
       /// </summary>        
       TernaryPred = FC.TernaryPred,   
    }    

    partial class ReflectedClass
    {
        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(this MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit) || m.ReturnType == typeof(bool));

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static PredicateClass ClassifyPredicate(this MethodInfo m)
        {
            if(m.IsPredicate())
            {
                return m.Arity() switch {
                    1 => PredicateClass.UnaryPred,
                    2 => PredicateClass.BinaryPred,
                    3 => PredicateClass.TernaryPred,
                    _ => PredicateClass.None

                };
            }
            return 0;
        }          

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
            => from m in src where m.ClassifyPredicate().IsSome() select m;
    }    
}