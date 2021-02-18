//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class Operation : IOperation
    {
        public Identifier Name {get;}

        public Index<Operand> Input {get;}

        public Operand? Output {get;}

        public OperationBody Definition {get;}

        [MethodImpl(Inline)]
        public Operation(Identifier name, Index<Operand> operands, Operand? output, Index<Statement> statements)
        {
            Name = name;
            Input = operands;
            Output = output;
            Definition = new OperationBody(this, statements);
        }
    }
}