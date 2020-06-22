//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
 
    using PC = PredicateClass;

    partial interface TIdentityReflector
    {
       /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        bool IsPredicate(MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType.Name =="bit" || m.ReturnType == typeof(bool));

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="m">The method to examine</param>
        PredicateClass ClassifyPredicate(MethodInfo m)
        {
            if(IsPredicate(m))
            {
                return m.ArityValue() switch {
                    1 => PC.UnaryPredicate,
                    2 => PC.BinaryPredicate,
                    3 => PC.TernaryPredicate,
                    _ => PC.None

                };
            }
            return 0;
        }

        /// <summary>
        /// Queries the stream for methods with a specified predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> WithPredicateClass(IEnumerable<MethodInfo> src, PredicateClass @class)
            => from m in src where ClassifyPredicate(m) == @class select m;

        /// <summary>
        /// Queries the stream for methods with a nonempty predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> WithPredicateClass(IEnumerable<MethodInfo> src)
            => from m in src where ClassifyPredicate(m) != 0 select m;         
    }
}