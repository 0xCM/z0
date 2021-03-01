//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct XedSeq : IXedRule<XedSeq>
    {
        public string Name {get;}

        public Index<string> Terms {get;}

        [MethodImpl(Inline)]
        public XedSeq(string name, string[] terms)
        {
            Name = name;
            Terms = terms;
        }

        public XedRuleKind RuleKind
            => XedRuleKind.Sequence;
    }
}