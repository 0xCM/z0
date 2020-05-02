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
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to classify</param>
        bool IsSource(MethodInfo m)
            => m.IsFunction() && m.HasArityValue(0);

        /// <summary>
        /// Determines whether a method has void return and has arity = 1
        /// </summary>
        /// <param name="m">The method to classify</param>
        bool IsSink(MethodInfo m)
            => m.HasVoidReturn() && m.ArityValue() == 1;
    }
}