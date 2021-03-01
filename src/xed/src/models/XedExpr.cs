//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct XedExpr : ITextual, IXedRule<XedExpr>
    {
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public XedExpr(string src)
            => Content = src;

        public XedRuleKind RuleKind
            => XedRuleKind.Expression;


        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Content;
    }
}