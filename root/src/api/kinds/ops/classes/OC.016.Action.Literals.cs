//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

    [Flags]
    public enum ActionClass : ushort
    { 
        /// <summary>
        /// Classifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies operations with void return
        /// </summary>        
        Action = OC.Action,

        /// <summary>
        /// Classifies actions that accept no arguments
        /// </summary>
        Receiver = OC.Receiver,

        /// <summary>
        /// Classifies actions that accept one argument
        /// </summary>
        UnaryAction = OC.UnaryAction,

        /// <summary>
        /// Classifies actions that accept two arguments
        /// </summary>
        BinaryAction = OC.BinaryAction,

        /// <summary>
        /// Classifies actions that accept three arguments
        /// </summary>
        TernaryAction = OC.TernaryAction
    }
}