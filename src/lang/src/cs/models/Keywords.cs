//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using Microsoft.CodeAnalysis.CSharp;

    public readonly struct Keywords
    {
        public readonly struct Switch : IKeyword<SyntaxKind,Switch>
        {
            public string Name => "switch";

            public SyntaxKind Kind => SyntaxKind.SwitchKeyword;
        }

        public readonly struct Case : IKeyword<SyntaxKind,Case>
        {
            public string Name => "case";

            public SyntaxKind Kind => SyntaxKind.CaseKeyword;
        }

        public static Switch @switch() => default(Switch);

        public static Case @case() => default(Case);
    }
}