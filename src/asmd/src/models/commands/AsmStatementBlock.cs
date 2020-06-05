//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public readonly struct AsmStatementBlock
    {
        public AsmHeader Header {get;}
        
        public readonly AsmStatement[] Statements;

        [MethodImpl(Inline)]
        public AsmStatementBlock(AsmHeader header, AsmStatement[] src)
        {
            this.Header = header;
            this.Statements = src;
        }        
    }
}