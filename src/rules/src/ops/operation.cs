//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op]
        public static Operation operation(string name, Index<OperandSpec> operands, OperandSpec? output, Index<Statement> statements)
            => new Operation(name, operands,output, statements);
    }
}