//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using static Rules;

    public readonly struct StatementBlock : IStatementBlock
    {
        public string Label {get;}

        public Index<Statement> Statements {get;}

        [MethodImpl(Inline)]
        public StatementBlock(string label, Index<Statement> statements)
        {
            Label = label;
            Statements = statements;
        }

        [MethodImpl(Inline)]
        public StatementBlock(Index<Statement> statements)
        {
            Label = EmptyString;
            Statements = statements;
        }
    }
}