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

    public readonly struct Rule
    {
        readonly RuleSpec Data;

        [MethodImpl(Inline)]
        public Rule(RuleId id, RuleOperand[] operands, RuleEffect effect)
        {
            Data.RuleId = id;
            Data.Operands = operands;
            Data.Effect = effect;
        }

        public Span<RuleOperand> Operands
        {
            [MethodImpl(Inline)]
            get => Data.Operands.Edit;
        }

        public ref RuleOperand this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Data.Operands[index];
        }

        public byte Arity
        {
            [MethodImpl(Inline)]
            get => (byte)Operands.Length;
        }
    }

    public readonly struct RuleEffect
    {
        public string Data {get;}

        [MethodImpl(Inline)]
        public RuleEffect(string src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator RuleEffect(string src)
            => new RuleEffect(src);
    }

    public readonly struct PrimalRule
    {
        public RuleId RuleId {get;}

        public RuleOperand Predicate {get;}

        public RuleEffect Effect {get;}

        [MethodImpl(Inline)]
        public PrimalRule(RuleId id, RuleOperand predicate, RuleEffect effector)
        {
            RuleId = id;
            Predicate = predicate;
            Effect = effector;
        }

        [MethodImpl(Inline)]
        public static implicit operator PrimalRule(Triple<string> src)
            => new PrimalRule(src.First, src.Second, src.Third);

    }

    public readonly struct PrimalRule<T>
    {

    }
    public readonly struct PrimalRule<A,B>
    {

    }
}