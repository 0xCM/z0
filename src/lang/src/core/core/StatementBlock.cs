//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IStatementBlock : IScope
    {

    }

    public readonly struct StatementBlock : IStatementBlock
    {
        public Identifier Label {get;}

        public Index<Statement> Statements {get;}

        [MethodImpl(Inline)]
        public StatementBlock(Identifier label, Index<Statement> statements)
        {
            Label = label;
            Statements = statements;
        }

        [MethodImpl(Inline)]
        public StatementBlock(Index<Statement> statements)
        {
            Label = Identifier.Empty;
            Statements = statements;
        }
    }
}