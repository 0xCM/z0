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
        public readonly struct LabeledBlock
        {
            public AsmLabel Label {get;}

            public Index<Statement> Statements {get;}

            [MethodImpl(Inline)]
            public LabeledBlock(AsmLabel label, Index<Statement> statements)
            {
                Label = label;
                Statements = statements;
            }
        }
    }
}