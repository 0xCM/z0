//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Classifies and describes operations defined over fixed operands
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="D">The operator type</typeparam>
    public readonly struct CellOpKind<W,T,D> : ICellOpKind<W,T,D>
        where W : unmanaged, ICellWidth
        where T : IDataCell
        where D : Delegate
    {
        public CellWidth OperandWidth
             => Widths.cell<W>();

        public Type OperandType
            => typeof(T);

        public Type OperatorType
            => typeof(D);

        public CellOpKind Untyped
        {
            [MethodImpl(Inline)]
            get => new CellOpKind(OperandWidth, OperandType, OperatorType);
        }

        [MethodImpl(Inline)]
        public static implicit operator CellOpKind(CellOpKind<W,T,D> src)
            => src.Untyped;
    }
}