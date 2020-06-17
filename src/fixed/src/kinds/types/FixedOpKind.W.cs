//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FixedOpKind<W,D> : IFixedOpKind<W,D>
        where W : unmanaged, IFixedWidth
        where D : Delegate
    {
        /// <summary>
        /// The fixed operand type
        /// </summary>
        public Type OperandType {get;}

        /// <summary>
        /// The fixed delegate type
        /// </summary>
        public Type OperatorType {get;}

        [MethodImpl(Inline)]
        public static implicit operator FixedOpKind(FixedOpKind<W,D> src)
            => src.Untyped;
        
        [MethodImpl(Inline)]
        public FixedOpKind(Type tOperand, Type tOp)
        {
            OperatorType = tOp;
            OperandType = tOperand;
        }

        /// <summary>
        /// The operand width
        /// </summary>
        public FixedWidth OperandWidth 
            => Widths.tfixed<W>();        

        public FixedOpKind Untyped 
        {
            [MethodImpl(Inline)]
            get => new FixedOpKind(OperandWidth, OperandType, OperatorType);
        }        
    }
}