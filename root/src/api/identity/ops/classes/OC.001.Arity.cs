//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Classes;

    using OC = OperationClass;
    using C = ArityClass;
    using K = Classes;


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

    public static partial class Classes
    {
        public readonly struct Unary : ILiteral<C> { public C Class => C.Unary; }

        public readonly struct Binary : ILiteral<C> { public C Class => C.Binary; }

        public readonly struct Ternary : ILiteral<C> { public C Class => C.Ternary; }

        public readonly struct Unary<T> : ILiteral<C,T> where T : unmanaged { public C Class => C.Unary; }

        public readonly struct Binary<T> : ILiteral<C,T>  where T : unmanaged { public C Class => C.Binary; }

        public readonly struct Ternary<T> : ILiteral<C,T>  where T : unmanaged { public C Class => C.Ternary; }
    }

    public static partial class ClassReps
    {
        public static K.Unary Unary => default;

        public static K.Binary Binary => default;

        public static K.Ternary Ternary => default;
        
        public static K.Unary<T> unary<T>() where T : unmanaged => default;

        public static K.Binary<T> binary<T>() where T : unmanaged => default;

        public static K.Ternary<T> ternary<T>() where T : unmanaged => default;
    }
}