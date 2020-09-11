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

    public readonly struct CellOpKind<W,D> : ICellOpKind<W,D>
        where W : unmanaged, ICellWidth
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
        public static implicit operator CellOpKind(CellOpKind<W,D> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public CellOpKind(Type tOperand, Type tOp)
        {
            OperatorType = tOp;
            OperandType = tOperand;
        }

        /// <summary>
        /// The operand width
        /// </summary>
        public CellWidth OperandWidth
            => Widths.cell<W>();

        public CellOpKind Untyped
        {
            [MethodImpl(Inline)]
            get => new CellOpKind(OperandWidth, OperandType, OperatorType);
        }
    }
}