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

    public readonly struct OperatorTypeClass : ITextual
    {
        /// <summary>
        /// The operator operand type
        /// </summary>
        public readonly Type OperandType;

        /// <summary>
        /// The operator classification
        /// </summary>
        public readonly ApiOperatorKind OperatorClass;

        public static OperatorTypeClass Infer(MethodInfo src)
        {
            var c = src.ClassifyOperator();
            if(c != 0)
                return new OperatorTypeClass(src.ReturnType,c);
            else
                return Empty;
        }

        [MethodImpl(Inline)]
        internal OperatorTypeClass(Type type, ApiOperatorKind @class)
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

        public string Format()
            => IsEmpty
            ? string.Empty
            : OperandType.DisplayName()
                         .Replicate(OperatorClass.ArityValue() + 1)
                         .Intersperse(AsciArrow)
                         .Concat();
        public override string ToString()
            => Format();

        public static OperatorTypeClass Empty
            => new OperatorTypeClass(typeof(void), 0);
    }
}