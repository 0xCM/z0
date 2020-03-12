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

    /// <summary>
    /// Defines a methods equivalence class: a method is either an action or a function
    /// </summary>
    public enum OperationClass : ulong
    {
        None = 0,

        Action = Pow2.T55,

        Function = Pow2.T56,
    }

    partial class ReflectedClass
    {
        /// <summary>
        /// Dtermines whether a method has a void return
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.HasVoidReturn();

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => ! m.HasVoidReturn();

        public static OperationClass ClassifyOperation(this MethodInfo m)            
            => m.IsAction() ? OperationClass.Action : OperationClass.Function;

        /// <summary>
        /// Queries the stream for methods with a specified operation classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithOperationClass(this IEnumerable<MethodInfo> src, OperationClass @class)
            => from m in src where m.ClassifyOperation() == @class select m;

        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Functions(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyOperation() == OperationClass.Function select m;

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Actions(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyOperation() == OperationClass.Action select m;
    }
}