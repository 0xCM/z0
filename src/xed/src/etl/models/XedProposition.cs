//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct XedProposition : IXedRule<XedProposition>
    {
        public XedRuleKind RuleKind => XedRuleKind.Proposition;

        public FS.FileName Source {get;}

        public uint Index {get;}

        public Name Name {get;}

        public Index<RuleOperand> Operands {get;}

        public TextBlock Consequent {get;}

        public XedProposition(uint index, FS.FileName src, Name name, Index<RuleOperand> operands, TextBlock consequent)
        {
            Index = index;
            Source = src;
            Name = name;
            Operands = operands;
            Consequent = consequent;
        }
    }
}