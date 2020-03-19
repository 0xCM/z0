//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    using OC = OperationClass;
    using C = OperatorClass;
    using K = Classes;
    
    using static Classes;


    /// <summary>
    /// Classifies operators of arity either 1, 2, or 3
    /// </summary>
    [Flags]
    public enum OperatorClass : ushort
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies functions for which operands and return type are homogenous
        /// </summary>        
        Operator = OC.Operator,

        /// <summary>
        /// Classifies operators that accept one argument
        /// </summary>        
        UnaryOp = OC.UnaryOp,

        /// <summary>
        /// Classifies operators that accept two arguments
        /// </summary>        
        BinaryOp = OC.BinaryOp,
        
        /// <summary>
        /// Classifies operators that accept three arguments
        /// </summary>        
        TernaryOp = OC.TernaryOp,
    }

    public static class OpClassOps
    {
    }
    

    public static partial class Classes
    {
        public readonly struct UnaryOp : IOpClass<C> { public C Class => C.UnaryOp; }

        public readonly struct BinaryOp : IOpClass<C> { public C Class => C.BinaryOp; }

        public readonly struct TernaryOp : IOpClass<C> { public C Class => C.TernaryOp; }

        public readonly struct UnaryOp<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.UnaryOp; }

        public readonly struct BinaryOp<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.BinaryOp; }

        public readonly struct TernaryOp<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.TernaryOp; }
    }

    public static partial class ClassReps
    {
        public static UnaryOp UnaryOp => default;

        public static BinaryOp BinaryOp => default;

        public static TernaryOp TernaryOp => default;

        public static K.UnaryOp<T> unaryOp<T>() 
            where T : unmanaged => default;

        public static K.BinaryOp<T> binaryOp<T>() 
            where T : unmanaged => default;

        public static K.TernaryOp<T> ternaryOp<T>() 
            where T : unmanaged => default;

        public static K.UnaryOp<T> As<T>(this K.UnaryOp src)        
            where T : unmanaged
                => default;
        
        public static K.BinaryOp<T> As<T>(this K.BinaryOp src)        
            where T : unmanaged
                => default;

        public static K.TernaryOp<T> As<T>(this K.TernaryOp src)        
            where T : unmanaged
                => default;
    }

    public readonly struct OperatorTypeClass
    {
        public static OperatorTypeClass None => Define(typeof(void), OperatorClass.None);

        /// <summary>
        /// The operator operand type
        /// </summary>
        public readonly Type OperandType;

        /// <summary>
        /// The operator classification
        /// </summary>
        public readonly OperatorClass OperatorClass;

        public static OperatorTypeClass Infer(MethodInfo src)
        {
            var c = src.ClassifyOperator();
            if(c != 0)
                return Define(src.ReturnType,c);
            else
                return None;
        }

        [MethodImpl(Inline)]
        public static OperatorTypeClass Define(Type type, OperatorClass @class)
            => new OperatorTypeClass(type, @class);

        [MethodImpl(Inline)]
        OperatorTypeClass(Type type, OperatorClass @class)
        {
            this.OperatorClass = @class;
            this.OperandType = type;
        }
        
        public bool IsNone
        {
            get => (OperandType == typeof(void) || OperandType == null) && OperatorClass.IsNone();
        }

        public bool IsSome
        {
            get => !IsNone;
        }

        public override string ToString()
            => IsNone ? string.Empty :  OperandType.DisplayName().Replicate(OperatorClass.ArityValue() + 1).Intersperse(ArrowSymbols.AsciArrow).Concat();        
    }    
}