//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct SemanticComment
        {
            public AsmSig Sig {get;}

            public AsmOpCode OpCode {get;}

            public EncodedStatement Encoded {get;}
        }
    }
}