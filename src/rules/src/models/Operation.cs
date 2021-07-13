//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public class Operation : IScopedOp
        {
            public string Name {get;}

            public Index<OperandSpec> Input {get;}

            public OperandSpec? Output {get;}

            public OperationBody Definition {get;}

            [MethodImpl(Inline)]
            public Operation(string name, Index<OperandSpec> operands, OperandSpec? output, Index<Statement> statements)
            {
                Name = name;
                Input = operands;
                Output = output;
                Definition = new OperationBody(this, statements);
            }
        }
    }
}