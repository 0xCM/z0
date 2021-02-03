//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct OperandValue
    {
        public Operand  Operand {get;}

        public Value Value {get;}

        [MethodImpl(Inline)]
        public OperandValue(Operand op, Value value)
        {
            Operand = op;
            Value = value;
        }
    }
}