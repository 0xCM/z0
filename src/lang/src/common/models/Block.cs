//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Block
    {
        public Identifier Label {get;}

        public Index<Statement> Statements {get;}

        [MethodImpl(Inline)]
        public Block(Identifier label, Index<Statement> statements)
        {
            Label = label;
            Statements = statements;
        }

        [MethodImpl(Inline)]
        public Block(Index<Statement> statements)
        {
            Label = Identifier.Empty;
            Statements = statements;
        }
    }
}