//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public readonly struct AsmStatementBlock
    {
        public AsmFunctionHeader Header {get;}
        
        public readonly AsmStatement[] Statements;

        [MethodImpl(Inline)]
        public AsmStatementBlock(AsmFunctionHeader header, AsmStatement[] src)
        {
            this.Header = header;
            this.Statements = src;
        }        
    }
}