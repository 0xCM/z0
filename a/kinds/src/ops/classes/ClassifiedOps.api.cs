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
 
    using AC = ArityClass;
    using OC = OperatorClass;

    public static partial class OpClass
    {
    
    }

    public static partial class OpClasses
    {
    }

    public static class ClassifiedOps
    {
        /// <summary>
        /// Dtermines whether a method has a void return
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(MethodInfo m)
            => m.IsAction();

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(MethodInfo m)
            => m.IsFunction();

        /// <summary>
        /// Determines whether a method is a function with numeric operands (if any) and return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumericFunction(MethodInfo m)
            => m.IsFunction() 
            && NumericKinds.test(m.ReturnType)
            && Enumerable.All<Type>(m.ParameterTypes(), t => t.NumericKind() != NumericKind.None);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to classify</param>
        public static bool IsSource(MethodInfo m)
            => m.IsFunction() && m.HasArityValue(0);

        /// <summary>
        /// Determines whether a method has void return and has arity = 1
        /// </summary>
        /// <param name="m">The method to classify</param>
        public static bool IsSink(MethodInfo m)
            => m.HasVoidReturn() && m.ArityValue() == 1;

        /// <summary>
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static ArityClass ArityClass(MethodInfo m)
            => m.ArityValue() switch{
                0 => AC.Nullary,
                1 => AC.Unary,
                2 => AC.Binary,
                3 => AC.Ternary,
                _ => AC.None
            };

        public static int ArityValue(OperatorClass src)
            => src switch{
               OC.UnaryOp => 1,
               OC.BinaryOp => 2,
               OC.TernaryOp => 3,     
                _  => 0,
            };

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsHomogenous(MethodInfo m)
        {
            var inputs = m.ParameterTypes().ToHashSet();
            if(inputs.Count == 1)
                return inputs.Single() == m.ReturnType;
            else if(inputs.Count == 0)
                return m.ReturnType == typeof(void);
            else
                return false;
        }

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsOperator(MethodInfo src)
            => IsFunction(src) && IsHomogenous(src) && src.ArityValue() >= 1;

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static OperatorClass ClassifyOperator(MethodInfo src)
        {
            if(IsOperator(src))
            {
                return src.ArityValue() switch {
                    1 => OperatorClass.UnaryOp,
                    2 => OperatorClass.BinaryOp,
                    3 => OperatorClass.TernaryOp,
                    _ => OperatorClass.None

                };
            }
            return 0;
        }

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType.Name =="bit" || m.ReturnType == typeof(bool));

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static PredicateClass ClassifyPredicate(MethodInfo m)
        {
            if(IsPredicate(m))
            {
                return m.ArityValue() switch {
                    1 => PredicateClass.UnaryPredicate,
                    2 => PredicateClass.BinaryPredicate,
                    3 => PredicateClass.TernaryPredicate,
                    _ => PredicateClass.None

                };
            }
            return 0;
        }
    }   
}