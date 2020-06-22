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
 
    using OC = OperatorClass;

    partial interface TIdentityReflector
    {
        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="src">The method to examine</param>
        bool IsOperator(MethodInfo src)
            => IsFunction(src) && IsHomogenous(src) && src.ArityValue() >= 1;

        /// <summary>
        /// Classifies a methods that is an operator and has arity between 1 and 3; otherwise, returns None
        /// </summary>
        /// <param name="src">The method to examine</param>
        OC ClassifyOperator(MethodInfo src)
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


        /// <summary>
        /// Queries the stream for methods with a nonempty operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> WithOperatorClass(IEnumerable<MethodInfo> src)
            => from m in src where ClassifyOperator(m) != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified operator classification
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> WithOperatorClass(IEnumerable<MethodInfo> src, OperatorClass @class)
            => from m in src where ClassifyOperator(m) == @class select m;
    }
}