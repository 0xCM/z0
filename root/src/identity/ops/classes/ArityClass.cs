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

    public enum ArityClass : ulong
    {
        None = 0,

        /// <summary>
        /// Classifies operations of arity 0
        /// </summary>        
        Nullary = Pow2.T00,
       
        /// <summary>
        /// Classifies operations of arity 1
        /// </summary>        
        Unary = Pow2.T01,

        /// <summary>
        /// Classifies operations of arity 2
        /// </summary>        
        Binary = Pow2.T02,

       /// <summary>
        /// Classifies operations of arity 3
       /// </summary>        
       Ternary = Pow2.T03,   
    }    

    partial class ReflectedClass
    {
        /// <summary>
        /// Assigns an arity classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static ArityClass ClassifyArity(this MethodInfo m)
            => m.Arity() switch{
                0 => ArityClass.Nullary,
                1 => ArityClass.Unary,
                2 => ArityClass.Binary,
                3 => ArityClass.Ternary,
                _ => ArityClass.None
            };

        /// <summary>
        /// Queries the stream for methods with a nonempty measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithArityClass(this IEnumerable<MethodInfo> src)
            => from m in src where m.ClassifyArity().IsSome() select m;

        /// <summary>
        /// Queries the stream for methods with a specified measure classification
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> WithArityClass(this IEnumerable<MethodInfo> src, ArityClass @class)
            => from m in src where m.ClassifyArity() == @class select m;


    }
}