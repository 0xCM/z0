//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

    [Flags]
    public enum ActionClass : ulong
    { 
        /// <summary>
        /// The empty classifier
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
        Action1 = OC.Action1,

        /// <summary>
        /// Classifies actions that accept two arguments
        /// </summary>
        Action2 = OC.Action2,

        /// <summary>
        /// Classifies actions that accept three arguments
        /// </summary>
        Action3 = OC.Action3
    }
}