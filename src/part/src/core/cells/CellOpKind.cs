//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CellOpKind
    {
        /// <summary>
        /// The operand width
        /// </summary>
        public CellWidth OperandWidth {get;}

        /// <summary>
        /// The fixed operand type
        /// </summary>
        public Type OperandType {get;}

        /// <summary>
        /// The fixed delegate type
        /// </summary>
        public Type OperatorType {get;}

        [MethodImpl(Inline)]
        public CellOpKind(CellWidth width, Type tOperand, Type tOp)
        {
            OperandWidth = width;
            OperatorType = tOp;
            OperandType = tOperand;
        }

    }
}