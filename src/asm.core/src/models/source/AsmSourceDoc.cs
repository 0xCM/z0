//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSourceDoc
    {
        public AsmSyntaxKind Syntax {get;}

        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmSourceDoc(AsmSyntaxKind syntax, string content)
        {
            Content = content;
            Syntax = syntax;
        }

        public static AsmSourceDoc Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSourceDoc(0,EmptyString);
        }
    }
}