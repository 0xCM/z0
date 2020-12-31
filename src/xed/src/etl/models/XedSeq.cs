//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct XedSeq : IXedRule<XedSeq>
    {
        public XedRuleKind RuleKind => XedRuleKind.Sequence;

        public string Name {get;}

        public Index<string> Terms {get;}

        public XedSeq(string name, string[] terms)
        {
            Name = name;
            Terms = terms;
        }
    }
}