//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a fixed operator descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    [Free]
    public interface ICellOpKind : ITextual
    {
        /// <summary>
        /// The operand width
        /// </summary>
        CellWidth OperandWidth {get;}

        /// <summary>
        /// The fixed operand type
        /// </summary>
        Type OperandType {get;}

        /// <summary>
        /// The fixed delegate type
        /// </summary>
        Type OperatorType {get;}

        CellOpKind Untyped
            => new CellOpKind(OperandWidth, OperandType, OperatorType);

        string ITextual.Format()
            => CellOpKinds.Format(this);
    }

    [Free]
    public interface ICellOpKind<F> : ICellOpKind, ITextual<F>
        where F : struct, ICellOpKind<F>
    {

    }

    /// <summary>
    /// Characterizes a width-parametric fixed operator descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    [Free]
    public interface ICellOpKind<W,D> : ICellOpKind
        where W : unmanaged, ICellWidth
        where D : Delegate
    {
        CellWidth ICellOpKind.OperandWidth
            => Widths.cell<W>();
    }

    /// <summary>
    /// Characterizes a width, operand and operator-parametric descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="D">The operator type</typeparam>
    [Free]
    public interface ICellOpKind<W,T,D> : ICellOpKind<W,D>
        where W : unmanaged, ICellWidth
        where T : IDataCell
        where D : Delegate
    {
        Type ICellOpKind.OperandType
            => typeof(T);

        Type ICellOpKind.OperatorType
            => typeof(D);
    }
}