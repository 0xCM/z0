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

    public readonly struct FixedOpKind : IFixedOpKind<FixedOpKind>
    {
        [MethodImpl(Inline)]
        public FixedOpKind(FixedWidth width, Type tOperand, Type tOp)
        {
            OperandWidth = width;
            OperatorType = tOp;
            OperandType = tOperand;
        }

        /// <summary>
        /// The operand width
        /// </summary>
        public FixedWidth OperandWidth {get;}        

        /// <summary>
        /// The fixed operand type
        /// </summary>
        public Type OperandType {get;}

        /// <summary>
        /// The fixed delegate type
        /// </summary>
        public Type OperatorType {get;}

        public override string ToString()
            => ((ITextual)this).Format();
    }
}