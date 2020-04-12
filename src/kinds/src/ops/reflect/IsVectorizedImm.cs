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
 
    partial class XTend
    {
        /// <summary>
        /// Determines whether a method is (partially) vectorized and accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedImm(this MethodInfo src)
            => src.IsVectorized() && src.AcceptsImmediate() && src.ReturnsVector();
        
        /// <summary>
        /// Determines whether a method is a vectorized unary operator that accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedUnaryImm(this MethodInfo src)
        {
            var parameters = src.GetParameters().ToArray();
            return parameters.Length == 2 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].IsImmediate()
                && src.ReturnsVector();
        }

        /// <summary>
        /// Determines whether a method is a vectorized binary operator that accepts an immediate value
        /// </summary>
        /// <param name="src">The method to query</param>
        public static bool IsVectorizedBinaryImm(this MethodInfo src)
        {
            var parameters = src.GetParameters().ToArray();
            return parameters.Length == 3 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].ParameterType.IsVector() 
                && parameters[2].IsImmediate()
                && src.ReturnsVector();
        }
    }
}