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

    partial class ReflectedClass
    {
        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to classify</param>
        public static bool IsSource(this MethodInfo m)
            => m.IsFunction() && m.HasArity(0);

        /// <summary>
        /// Determines whether a method has void return and has arity = 1
        /// </summary>
        /// <param name="m">The method to classify</param>
        public static bool IsSink(this MethodInfo m)
            => m.HasVoidReturn() && m.Arity() == 1;
    }
}