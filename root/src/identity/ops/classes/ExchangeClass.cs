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

    public enum ExchangeClass : ulong
    {
        None = 0,
        
        /// <summary>
        /// Classifies operations with void return that have arity 1
        /// </summary>        
        Sink = 1,

        /// <summary>
        /// Classifies operations with non-void return that accept no inpute
        /// </summary>        
        Source = 2,
    }

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

        /// <summary>
        /// Assigns an exchange classification to a method, if any
        /// </summary>
        /// <param name="m">The method to classify</param>
        public static ExchangeClass ClassifyExchange(this MethodInfo m)
            => m.IsSource() ? ExchangeClass.Source : m.IsSink() ? ExchangeClass.Sink : ExchangeClass.None;

        /// <summary>
        /// Queries the stream for methods with a nonempty exchange classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithExchangeClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyExchange().IsSome() select m;

        /// <summary>
        /// Queries the stream for methods with a specified exchange classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithExchangeClass(this IEnumerable<MethodInfo> src, ExchangeClass @class)
            => from m in src where m.ClassifyExchange() == @class select m;
    }
}