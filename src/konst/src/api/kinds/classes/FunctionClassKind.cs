//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClassKind;

    [Flags]
    public enum FunctionClassKind : ushort
    {
        /// <summary>
        /// Classifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifier root
        /// </summary>
        Function = OC.Function,

        /// <summary>
        /// Classifies functions that accept no arguments
        /// </summary>
        Emitter = OC.Emitter,

        /// <summary>
        /// Classifies functions that accept one argument
        /// </summary>
        UnaryFunc = OC.UnaryFunc,

        /// <summary>
        /// Classifies functions that accept two arguments
        /// </summary>
        BinaryFunc = OC.BinaryFunc,

        /// <summary>
        /// Classifies functions that accept three arguments
        /// </summary>
        TernaryFunc = OC.TernaryFunc,        
                        
        /// <summary>
        /// Classifies operators that accept one argument
        /// </summary>        
        UnaryOp = OC.UnaryOp,

        /// <summary>
        /// Classifies operators that accept two arguments
        /// </summary>        
        BinaryOp = OC.BinaryOp,

        /// <summary>
        /// Classifies operators that accept tjree arguments
        /// </summary>        
        TernaryOp = OC.TernaryOp,
    } 
}