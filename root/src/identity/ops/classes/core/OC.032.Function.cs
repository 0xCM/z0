//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

    [Flags]
    public enum FunctionClass : ulong
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        Emitter = OC.Emitter,

        /// <summary>
        /// An operation that accepts one argument and has a non-void return type
        /// </summary>
        Function1 = OC.Function1,

        /// <summary>
        /// An operation that accepts two arguments and has a non-void return type
        /// </summary>
        Function2 = OC.Function2,

        /// <summary>
        /// An operation that accepts three arguments and has a non-void return type
        /// </summary>
        Function3 = OC.Function3,        
                        
        /// <summary>
        /// Classifies operators that accept one argument
        /// </summary>        
        UnaryOperator = OC.UnaryOperator,

        /// <summary>
        /// Classifies operators that accept two arguments
        /// </summary>        
        BinaryOperator = OC.BinaryOperator,

        /// <summary>
        /// Classifies operators that accept tjree arguments
        /// </summary>        
        TernaryOperator = OC.TernaryOperator,
    } 
}