//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using OC = ApiOperatorClass;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsOperator(this MethodInfo src)
            => src.IsFunction() && src.IsHomogenous() && src.ArityValue() >= 1;

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsHomogenous(this MethodInfo src)
        {
            var inputs = src.ParameterTypes().ToHashSet();
            if(inputs.Count == 1)
                return inputs.Single() == src.ReturnType;
            else if(inputs.Count == 0)
                return src.ReturnType == typeof(void);
            else
                return false;
        }

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static ApiOperatorClass ClassifyOperator(this MethodInfo src)
        {
            if(IsOperator(src))
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