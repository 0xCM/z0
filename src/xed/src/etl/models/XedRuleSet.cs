//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct XedRuleSet
    {
        public FS.FileName SourceFile {get;}

        public FS.FileName TargetFile {get;}

        public string Name {get;}

        public string ReturnType {get;}

        public XedRule[] Terms {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public XedRuleSet(FS.FileName src, string name, string returns, XedRule[] terms, FS.FileName dst)
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