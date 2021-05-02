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
    }
}