//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmExpr
    {
        public readonly struct Statement : IEquatable<Statement>
        {
            public TextBlock Content {get;}

            [MethodImpl(Inline)]
            public Statement(TextBlock content)
                => Content = content;

            [MethodImpl(Inline)]
            public bool Equals(Statement src)
                => Content.Equals(src.Content);

            public override int GetHashCode()
                => Content.GetHashCode();

            public override bool Equals(object src)
                => src is Statement x && Equals(x);

            public int CompareTo(Statement src)
                => Content.CompareTo(src.Content);
        }
    }
}