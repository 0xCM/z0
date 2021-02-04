//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;

    partial struct AsmDocParts
    {
        public readonly struct SemanticComment
        {
            public Signature Sig {get;}

            public AsmOpCodeExprLegacy OpCode {get;}

            public EncodedStatement Encoded {get;}

            [MethodImpl(Inline)]
            public SemanticComment(Signature sig, AsmOpCodeExprLegacy oc, EncodedStatement encoded)
            {
                Sig = sig;
                OpCode = oc;
                Encoded = encoded;
            }
        }
    }
}