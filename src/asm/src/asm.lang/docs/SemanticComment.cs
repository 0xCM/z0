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
            public AsmSigExpr Sig {get;}

            public AsmOpCodeExpr OpCode {get;}

            public EncodedStatement Encoded {get;}

            [MethodImpl(Inline)]
            public SemanticComment(AsmSigExpr sig, AsmOpCodeExpr oc, EncodedStatement encoded)
            {
                Sig = sig;
                OpCode = oc;
                Encoded = encoded;
            }
        }
    }
}