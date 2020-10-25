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
    using System.Runtime.Intrinsics;

    using static Konst;

    using AC = ArityKind;
    using OC = ApiOperatorClass;
    using PC = ApiPredicateClass;

    [ApiHost(ApiNames.ApiIdentityReflector, true)]
    public readonly struct IdentityReflector
    {
        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to classify</param>
        [Op]
        public static bool IsSource(MethodInfo m)
            => m.IsFunction() && m.HasArityValue(0);

        /// <summary>
        /// Determines whether a method has void return and has arity = 1
        /// </summary>
        /// <param name="m">The method to classify</param>
        [Op]
        public static bool IsSink(MethodInfo m)
            => m.HasVoidReturn() && m.ArityValue() == 1;

        /// <summary>
        /// Queries the stream for methods with a nonempty arity classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithArityClass(MethodInfo[] src)
            => from m in src where ArityClass(m) != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified arity classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithArityClass(MethodInfo[] src, ArityKind @class)
            => from m in src where ArityClass(m) == @class select m;

        /// <summary>
        /// Determines whether a method is a function with numeric operands (if any) and return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static bool IsNumericFunction(MethodInfo m)
            => m.IsFunction()
            && NumericKinds.test(m.ReturnType)
            && Enumerable.All<Type>(m.ParameterTypes(), t => t.NumericKind() != NumericKind.None);

        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] Functions(MethodInfo[] src)
            => src.Where(m => m.IsFunction());

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] Actions(MethodInfo[] src)
            => src.Where(m => m.IsAction());

        /// <summary>
        /// Queries the stream for methods with a specified predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithPredicateClass(MethodInfo[] src, ApiPredicateClass @class)
            => from m in src where ClassifyPredicate(m) == @class select m;

        /// <summary>
        /// Queries the stream for methods with a nonempty predicate classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithPredicateClass(MethodInfo[] src)
            => from m in src where ClassifyPredicate(m) != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a nonempty operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithOperatorClass(MethodInfo[] src)
            => from m in src where m.ClassifyOperator() != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        [Op]
        public static MethodInfo[] WithOperatorClass(MethodInfo[] src, ApiOperatorClass @class)
            => from m in src where m.ClassifyOperator() == @class select m;

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static bool IsPredicate(MethodInfo m)
            => m.ParameterTypes().Distinct().Count() == 1
            && (m.ReturnType.Name =="bit" || m.ReturnType == typeof(bool));

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static ApiPredicateClass ClassifyPredicate(MethodInfo m)
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
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static ArityKind ArityClass(MethodInfo m)
            => m.ArityValue() switch{
                0 => AC.Nullary,
                1 => AC.Unary,
                2 => AC.Binary,
                3 => AC.Ternary,
                _ => AC.None
            };

        [Op]
        public static int ArityValue(ApiOperatorClass src)
            => src switch{
               OC.UnaryOp => 1,
               OC.BinaryOp => 2,
               OC.TernaryOp => 3,
                _  => 0,
            };


        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        [Op]
        public static OC ClassifyOperator(MethodInfo src)
        {
            if(src.IsOperator())
            {
                return src.ArityValue() switch {
                    1 => OC.UnaryOp,
                    2 => OC.BinaryOp,
                    3 => OC.TernaryOp,
                    _ => OC.None

                };
            }
            return 0;
        }

    }
}