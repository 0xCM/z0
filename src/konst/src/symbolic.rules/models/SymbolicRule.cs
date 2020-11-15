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

    public readonly struct SymbolicRule<T>
    {
        public RuleId RuleId {get;}

        public RuleOperand<T>[] Operands {get;}

        public Consequence<T> Implication {get;}

        [MethodImpl(Inline)]
        public SymbolicRule(RuleId id, RuleOperand<T>[] operands, Consequence<T> effect)
        {
            RuleId = id;
            Operands = operands;
            Implication = effect;
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