//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        [MethodImpl(Inline), Op]
        public static Operation operation(Identifier name, Index<Operand> operands, Operand? output, Index<Statement> statements)
            => new Operation(name, operands,output, statements);
    }
}