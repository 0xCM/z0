//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using OC = OperatorClassKind;

    partial interface TIdentityReflector
    {
        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        bool AcceptsVector(MethodInfo src, int index, W128 w)
            => IdentityReflector.AcceptsVector(src,index,w);

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        bool AcceptsVector(MethodInfo src, int index, W256 w)
            => IdentityReflector.AcceptsVector(src,index,w);

        int ArityValue(OperatorClassKind src)
            => src switch{
               OC.UnaryOp => 1,
               OC.BinaryOp => 2,
               OC.TernaryOp => 3,
                _  => 0,
            };

    }
}