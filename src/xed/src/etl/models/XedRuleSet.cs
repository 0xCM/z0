//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct XedRuleSet : IXedRule<XedRuleSet>
    {
        public XedRuleKind RuleKind => XedRuleKind.Ruleset;

        public FS.FileName SourceFile;

        public FS.FileName TargetFile;

        public string Name;

        public string ReturnType;

        public Index<XedExpr> Terms;

        public string Description;

        [MethodImpl(Inline)]
        public XedRuleSet(FS.FileName src, string name, string returns, Index<XedExpr> terms, FS.FileName dst)
        {
            SourceFile = src;
            TargetFile = dst;
            Name = name;
            ReturnType = returns;
            Terms = terms;
            Description =  text.concat("# ", SourceFile, Chars.FSlash, XedSourceMarkers.RuleHeader(Name), ReturnType);
        }
    }
}