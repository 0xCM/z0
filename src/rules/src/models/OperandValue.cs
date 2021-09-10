//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct OperandValue
        {
            public OperandSpec Operand {get;}

            public Value Value {get;}

            [MethodImpl(Inline)]
            public OperandValue(OperandSpec op, Value value)
            {
                Operand = op;
                Value = value;
            }
        }
    }
}