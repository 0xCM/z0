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
 
    using AC = ArityClassKind;
    using OC = OperatorClassKind;

    partial interface TIdentityReflector
    {
        /// <summary>
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        ArityClassKind ArityClass(MethodInfo m)
            => m.ArityValue() switch{
                0 => AC.Nullary,
                1 => AC.Unary,
                2 => AC.Binary,
                3 => AC.Ternary,
                _ => AC.None
            };

        int ArityValue(OperatorClassKind src)
            => src switch{
               OC.UnaryOp => 1,
               OC.BinaryOp => 2,
               OC.TernaryOp => 3,     
                _  => 0,
            };

        /// <summary>
        /// Queries the stream for methods with a nonempty arity classification
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> WithArityClass(IEnumerable<MethodInfo> src)
            => from m in src where ArityClass(m) != 0 select m;

        /// <summary>
        /// Queries the stream for methods with a specified arity classification
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> WithArityClass(IEnumerable<MethodInfo> src, ArityClassKind @class)
            => from m in src where ArityClass(m) == @class select m;
    }
}