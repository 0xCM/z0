//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

    public enum OperationClassId : ulong
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifier identity for operations of arity 0
        /// </summary>        
        Nullary = OC.Nullary,

        /// <summary>
        /// Classifier identity for operations of arity 1
        /// </summary>        
        Unary = OC.Unary,

        /// <summary>
        /// Classifier identity for operations of arity 2
        /// </summary>        
        Binary = OC.Binary,

        /// <summary>
        /// Classifier identity for operations of arity 3
        /// </summary>        
        Ternary = OC.Ternary,

        /// <summary>
        /// Classifier identity for operations with void return
        /// </summary>        
        Action = OC.Action,

        /// <summary>
        /// Classifier identity for operations with non-void return
        /// </summary>        
        Function = OC.Function,

        /// <summary>
        /// Classifier identity for functions with homogenous input/output types
        /// </summary>        
        Operator = OC.Operator,

        /// <summary>
        /// Classifer identity for functions that return a system boolean value or a bit value
        /// </summary>        
        Predicate = OC.Predicate,
    }
}