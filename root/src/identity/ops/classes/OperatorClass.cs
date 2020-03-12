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

    using FK = FunctionClass;
    using static OperatorClass;

    /// <summary>
    /// Classifies operators of arity either 1, 2, or 3
    /// </summary>
    public enum OperatorClass : ulong
    {
        None = 0,

        UnaryOp = FK.UnaryOp,

        BinaryOp = FK.BinaryOp,
        
        TernaryOp = FK.TernaryOp,
    }

    partial class ReflectedClass
    {
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
               UnaryOp => 1,
               BinaryOp => 2,
               TernaryOp => 3,     
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
                    1 => OperatorClass.UnaryOp,
                    2 => OperatorClass.BinaryOp,
                    3 => OperatorClass.TernaryOp,
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

    }
}