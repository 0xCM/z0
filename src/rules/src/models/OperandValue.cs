//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct OperandValue
        {
            public OperandSpec  Operand {get;}

            public Value Value {get;}

            [MethodImpl(Inline)]
            public OperandValue(OperandSpec op, Value value)
            {
                Operand = op;
                Value = value;
            }
        }

        public readonly struct OperandValue<T>
        {
            public OperandSpec  Operand {get;}

            public T Value {get;}

            [MethodImpl(Inline)]
            public OperandValue(OperandSpec op, T value)
            {
                Operand = op;
                Value = value;
            }

            [MethodImpl(Inline)]
            public OperandValue Untype()
                => new OperandValue(Operand, new Value(Operand.Type, Value));

            [MethodImpl(Inline)]
            public static implicit operator OperandValue(OperandValue<T> src)
                => src.Untype();
        }
    }
}