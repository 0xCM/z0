//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Function : IDeclaration<Function>
    {
        public Identifier Name {get;}

        public Index<Operand> Operands {get;}

        public Index<Statement> Statements {get;}

        public Function(Identifier name, Index<Operand> operands, Index<Statement> statements)
        {
            Name = name;
            Operands = operands;
            Statements = statements;
        }
    }
}