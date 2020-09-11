//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a fixed operator descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    public interface IFixedOpKind : ITextual
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
        {
            var name = OperatorType.DisplayName();
            var width = OperandWidth.Format();
            var operand = OperandType.DisplayName();
            var format = text.concat(name, Chars.LBracket, width, Chars.RBracket, Chars.Colon, operand, Chars.MapsTo, operand);
            return format;
        }
    }

    public interface ICellOpKind<F> : IFixedOpKind, ITextual<F>
        where F : struct, ICellOpKind<F>
    {

    }

    /// <summary>
    /// Characterizes a width-parametric fixed operator descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    public interface ICellOpKind<W,D> : IFixedOpKind
        where W : unmanaged, ICellWidth
        where D : Delegate
    {

        CellWidth IFixedOpKind.OperandWidth
            => Widths.cell<W>();
    }

    /// <summary>
    /// Characterizes a width, operand and operator-parametric descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="D">The operator type</typeparam>
    public interface ICellOpKind<W,T,D> : ICellOpKind<W,D>
        where W : unmanaged, ICellWidth
        where T : IDataCell
        where D : Delegate
    {

        Type IFixedOpKind.OperandType
            => typeof(T);

        Type IFixedOpKind.OperatorType
            => typeof(D);
    }
}