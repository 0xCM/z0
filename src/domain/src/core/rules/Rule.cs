//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Rule<T>
    {
        public RuleId RuleId {get;}

        public RuleOperand<T>[] Operands {get;}

        public RuleEffect<T> Effect {get;}

        [MethodImpl(Inline)]
        public Rule(RuleId id, RuleOperand<T>[] operands, RuleEffect<T> effect)
        {
            RuleId = id;
            Operands = operands;
            Effect = effect;
        }

        public ref RuleOperand<T> this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Operands[index];
        }

        public byte Arity
        {
            [MethodImpl(Inline)]
            get => (byte)Operands.Length;
        }
    }
}