//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OperatorTypeClass
    {
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
                return new OperatorTypeClass(src.ReturnType,c);
            else
                return Empty;
        }

        [MethodImpl(Inline)]
        internal OperatorTypeClass(Type type, OperatorClass @class)
        {
            OperandType = type;
            OperatorClass = @class;                                    
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => OperandType.IsEmpty();
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public override string ToString()
            => IsEmpty 
            ? string.Empty 
            : OperandType.DisplayName()
                         .Replicate(OperatorClass.ArityValue() + 1)
                         .Intersperse(AsciArrow)
                         .Concat();        
        
        public static OperatorTypeClass Empty 
            => new OperatorTypeClass(typeof(void), 0);
    }    
}