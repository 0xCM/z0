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

    using OC = OperationClass;
    using static OperatorClass;
    

    partial class ReflectedClass
    {
        /// <summary>
        /// Dtermines whether a method has a void return
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.HasVoidReturn();

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => ! m.HasVoidReturn();

        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Functions(this IEnumerable<MethodInfo> src)
            => src.Where(IsFunction);

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Actions(this IEnumerable<MethodInfo> src)
            => src.Where(IsAction);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to classify</param>
        public static bool IsSource(this MethodInfo m)
            => m.IsFunction() && m.HasArity(0);

        /// <summary>
        /// Determines whether a method has void return and has arity = 1
        /// </summary>
        /// <param name="m">The method to classify</param>
        public static bool IsSink(this MethodInfo m)
            => m.HasVoidReturn() && m.Arity() == 1;

        /// <summary>
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static ArityClass ClassifyArity(this MethodInfo m)
            => m.Arity() switch{
                0 => ArityClass.Nullary,
                1 => ArityClass.Unary,
                2 => ArityClass.Binary,
                3 => ArityClass.Ternary,
                _ => ArityClass.None
            };

        /// <summary>
        /// Queries the stream for methods with a nonempty measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithArityClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyArity().IsSome() select m;

        /// <summary>
        /// Queries the stream for methods with a specified measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithArityClass(this IEnumerable<MethodInfo> src, ArityClass @class)
            => from m in src where m.ClassifyArity() == @class select m;

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsHomogenous(this MethodInfo m)
        {
            var inputs = m.ParameterTypes().ToHashSet();
            if(inputs.Count == 1)
                return inputs.Single() == m.ReturnType;
            else if(inputs.Count == 0)
                return m.ReturnType == typeof(void);
            else
                return false;
        }

        public static int Arity(this OperatorClass src)
            => src switch{
               UnaryOperator => 1,
               BinaryOperator => 2,
               TernaryOperator => 3,     
                _  => 0,
            };

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m)
            => m.IsFunction() && m.IsHomogenous() && m.Arity() >= 1;

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static OperatorClass ClassifyOperator(this MethodInfo m)
        {
            if(m.IsOperator())
            {
                return m.Arity() switch {
                    1 => OperatorClass.UnaryOperator,
                    2 => OperatorClass.BinaryOperator,
                    3 => OperatorClass.TernaryOperator,
                    _ => OperatorClass.None

                };
            }
            return 0;
        }

        /// <summary>
        /// Queries the stream for methods with a nonempty operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithOperatorClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyOperator().IsSome() select m;

        /// <summary>
        /// Queries the stream for methods with a specified operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithOperatorClass(this IEnumerable<MethodInfo> src, OperatorClass @class)
            => from m in src where m.ClassifyOperator() == @class select m;

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