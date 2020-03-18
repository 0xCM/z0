//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static OpTypes;

    using C = ActionClass;
    using OC = OperationClass;


    [Flags]
    public enum ActionClass : ushort
    { 
        /// <summary>
        /// The empty class
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

    public static partial class OpTypes
    {

        public readonly struct Receiver : IKind<Receiver, C> { public C Class => C.Receiver; }

        public readonly struct Receiver<T> : IKind<Receiver, C, T> where T : unmanaged { public C Class => C.Receiver; }
    }

    public static partial class OpReps
    {
        public static Receiver Receiver => default;

        public static Receiver<T> receiver<T>() where T : unmanaged => default;

    }
}