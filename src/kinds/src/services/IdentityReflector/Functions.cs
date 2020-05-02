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
 
    partial interface IIdentityReflector
    {
        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        bool IsFunction(MethodInfo m)
            => m.IsFunction();

        /// <summary>
        /// Determines whether a method is a function with numeric operands (if any) and return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        bool IsNumericFunction(MethodInfo m)
            => m.IsFunction() 
            && NumericKinds.test(m.ReturnType)
            && Enumerable.All<Type>(m.ParameterTypes(), t => t.NumericKind() != NumericKind.None);


        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> Functions(IEnumerable<MethodInfo> src)
            => src.Where(IdentityReflector.Service.IsFunction);
    }
}