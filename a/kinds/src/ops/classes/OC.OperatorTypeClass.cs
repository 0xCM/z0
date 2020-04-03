//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

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

        public static OperatorTypeClass Define(Type type, OperatorClass @class)
            => new OperatorTypeClass(type, @class);

        OperatorTypeClass(Type type, OperatorClass @class)
        {
            this.OperatorClass = @class;
            this.OperandType = type;
        }
        
        public bool IsNone
        {
            get => (OperandType == typeof(void) || OperandType == null) && OperatorClass == 0;
        }

        public bool IsSome
        {
            get => !IsNone;
        }

        const string AsciArrow = "->";

        public override string ToString()
            => IsNone 
            ? string.Empty 
            : OperandType.DisplayName()
                         .Replicate(OperatorClass.ArityValue() + 1)
                         .Intersperse(AsciArrow)
                         .Concat();        
    }    
}