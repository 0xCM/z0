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
    
    public enum MeasureClass : ulong
    {
        None = 0,

        /// <summary>
        /// Classifies a unary function that returns a numeric value
        /// </summary>
        UnaryMeasure = FC.UnaryMeasure,

        /// <summary>
        /// Classifies a homogenous binary function that returns a numeric value
        /// </summary>
        BinaryMeasure = FC.BinaryMeasure,

        /// <summary>
        /// Classifies a homogenous ternary function that returns a numeric value
        /// </summary>
        TernaryMeasure = FC.TernaryMeasure,
    }

    partial class ReflectedClass
    {
        /// <summary>
        /// Determines whether a method is a function accepts one or more arguments an returns a numeric or enum value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsMeasure(this MethodInfo m)
            => m.IsHomogenousFunction() && m.Arity() >= 1 
            && (m.ReturnType.NumericKind().IsSome() || m.ReturnType.IsEnum);

        /// <summary>
        /// Assigns a measure classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static MeasureClass ClassifyMeasure(this MethodInfo m)
        {
            if(m.IsMeasure())
            {
                return m.Arity() switch {
                    1 => MeasureClass.UnaryMeasure,
                    2 => MeasureClass.BinaryMeasure,
                    3 => MeasureClass.TernaryMeasure,
                    _ => MeasureClass.None

                };
            }
            return 0;
        }

        /// <summary>
        /// Queries the stream for methods with a nonempty measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithMeasureClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyMeasure().IsSome() select m;

        /// <summary>
        /// Queries the stream for methods with a specified measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithMeasureClass(this IEnumerable<MethodInfo> src, MeasureClass @class)
            => from m in src where m.ClassifyMeasure() == @class select m;

        public static TypedOperatorClass ClassifyTypedOperator(this MethodInfo src)
            => TypedOperatorClass.Infer(src);
    }    
}