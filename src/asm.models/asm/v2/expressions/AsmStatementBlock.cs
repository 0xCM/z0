//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmStatementBlock
    {
        public AsmRoutineHeader Header {get;}
        
        public readonly AsmStatement[] Statements;

        [MethodImpl(Inline)]
        public AsmStatementBlock(AsmRoutineHeader header, AsmStatement[] src)
        {
            Header = header;
            Statements = src;
        }        
    }
}