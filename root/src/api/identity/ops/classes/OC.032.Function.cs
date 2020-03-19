//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Classes;

    using OC = OperationClass;
    using C = FunctionClass;

    [Flags]
    public enum FunctionClass : ushort
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        Emitter = OC.Emitter,

        /// <summary>
        /// An operation that accepts one argument and has a non-void return type
        /// </summary>
        Func1 = OC.Func1,

        /// <summary>
        /// An operation that accepts two arguments and has a non-void return type
        /// </summary>
        Func2 = OC.Func2,

        /// <summary>
        /// An operation that accepts three arguments and has a non-void return type
        /// </summary>
        Func3 = OC.Func3,        
                        
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

    public static partial class Classes
    {
        public readonly struct Emitter : IOpClass<C> { public C Class => C.Emitter; }

        public readonly struct Func1 : IOpClass<C> { public C Class => C.Func1; }

        public readonly struct Func2 : IOpClass<C> { public C Class => C.Func2; }

        public readonly struct Func3 : IOpClass<C> { public C Class => C.Func3; }
     
        public readonly struct Emitter<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.Emitter; }

        public readonly struct Func1<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.Func1; }

        public readonly struct Func2<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.Func2; }

        public readonly struct Func3<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.Func3; }
    }    

    public static partial class ClassReps
    {
        public static Emitter Emitter => default;

        public static Func1 Func1 => default;

        public static Func2 Func2 => default;

        public static Func3 Func3 => default;

        public static Emitter<T> emitter<T>() where T : unmanaged => default;

        public static Func1<T> func1<T>() where T : unmanaged =>  default;

        public static Func2<T> func2<T>() where T : unmanaged => default;

        public static Func3<T> func3<T>() where T : unmanaged => default;

    }
}