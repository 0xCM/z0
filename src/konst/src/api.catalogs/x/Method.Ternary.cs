//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XKinds
    {
        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static bool IsTernaryFunction(this MethodInfo m)
            => m.IsFunction() && m.HasArityValue(3);

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        [Op]
        public static bool IsTernaryOperator(this MethodInfo m)
            => m.IsHomogenous() && m.IsTernaryFunction();

        /// <summary>
        /// Selects ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static MethodInfo[] TernaryOperators(this MethodInfo[] src)
            => src.Where(x => x.IsTernaryOperator());
    }
}