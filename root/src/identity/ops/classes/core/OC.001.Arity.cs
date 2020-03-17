//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static OpTypes;

    using OC = OperationClass;
    using C = ArityClass;

    [Flags]
    public enum ArityClass : ushort
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies operations of arity 0
        /// </summary>        
        Nullary = OC.Nullary,

        /// <summary>
        /// Classifies operations of arity 1
        /// </summary>        
        Unary = OC.Unary,

        /// <summary>
        /// Classifies operations of arity 2
        /// </summary>        
        Binary = OC.Binary,

        /// <summary>
        /// Classifies operations of arity 3
        /// </summary>        
        Ternary = OC.Ternary,   
    }    

    public static partial class OpTypes
    {
        public readonly struct Unary : IKind<Unary, C> { public C Class => C.Unary; }

        public readonly struct Binary : IKind<Binary, C> { public C Class => C.Binary; }

        public readonly struct Ternary : IKind<Ternary, C> { public C Class => C.Ternary; }

        public readonly struct Unary<T> : IKind<Unary<T>, C, T> where T : unmanaged { public C Class => C.Unary; }

        public readonly struct Binary<T> : IKind<Binary<T>, C, T>  where T : unmanaged { public C Class => C.Binary; }

        public readonly struct Ternary<T> : IKind<Ternary<T>, C, T>  where T : unmanaged { public C Class => C.Ternary; }
    }

    public static partial class OpReps
    {
        public static Unary Unary => default;

        public static Binary Binary => default;

        public static Ternary Ternary => default;
        
        public static Unary<T> unary<T>() where T : unmanaged => default;

        public static Binary<T> binary<T>() where T : unmanaged => default;

        public static Ternary<T> ternary<T>() where T : unmanaged => default;
    }

}