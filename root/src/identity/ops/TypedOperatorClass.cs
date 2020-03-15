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

    public readonly struct TypedOperatorClass
    {
        public static TypedOperatorClass None => Define(typeof(void), OperatorClass.None);

        /// <summary>
        /// The operator operand type
        /// </summary>
        public readonly Type OperandType;

        /// <summary>
        /// The operator classification
        /// </summary>
        public readonly OperatorClass OperatorClass;

        public static TypedOperatorClass Infer(MethodInfo src)
        {
            var c = src.ClassifyOperator();
            if(c.IsSome())
                return Define(src.ReturnType,c);
            else
                return None;
        }

        [MethodImpl(Inline)]
        public static TypedOperatorClass Define(Type type, OperatorClass @class)
            => new TypedOperatorClass(type, @class);

        [MethodImpl(Inline)]
        TypedOperatorClass(Type type, OperatorClass @class)
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
            => IsNone ? string.Empty :  OperandType.DisplayName().Replicate(OperatorClass.Arity() + 1).Intersperse(ArrowSymbols.AsciArrow).Concat();        
    }

    partial class ReflectedClass
    {

        public static TypedOperatorClass ClassifyTypedOperator(this MethodInfo src)
            => TypedOperatorClass.Infer(src);
    }        
}