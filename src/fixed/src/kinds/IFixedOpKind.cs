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
        FixedWidth OperandWidth {get;}

        /// <summary>
        /// The fixed operand type
        /// </summary>
        Type OperandType {get;}

        /// <summary>
        /// The fixed delegate type
        /// </summary>
        Type OperatorType {get;}

        FixedOpKind Untyped
            => new FixedOpKind(OperandWidth, OperandType, OperatorType);

        string ITextual.Format()
        {
            var name = OperatorType.DisplayName();
            var width = OperandWidth.Format();
            var operand = OperandType.DisplayName();
            var format = text.concat(name, Chars.LBracket, width, Chars.RBracket, Chars.Colon, operand, Chars.MapsTo, operand);
            return format;
        }
    }

    public interface IFixedOpKind<F> : IFixedOpKind, ITextual<F>
        where F : struct, IFixedOpKind<F>
    {

    }

    /// <summary>
    /// Characterizes a width-parametric fixed operator descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    public interface IFixedOpKind<W,D> : IFixedOpKind
        where W : unmanaged, IFixedWidth
        where D : Delegate
    {

        FixedWidth IFixedOpKind.OperandWidth
            => Widths.tfixed<W>();
    }

    /// <summary>
    /// Characterizes a width, operand and operator-parametric descriptor which both characterizes and describes
    /// an operator defined over operands of fixed-width
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="D">The operator type</typeparam>
    public interface IFixedOpKind<W,T,D> : IFixedOpKind<W,D>
        where W : unmanaged, IFixedWidth
        where T : IDataCell
        where D : Delegate
    {

        Type IFixedOpKind.OperandType
            => typeof(T);

        Type IFixedOpKind.OperatorType
            => typeof(D);
    }
}