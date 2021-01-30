//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public struct AsmCatalogEntry
    {
        public Sequential Sequence;

        public Name Identifier;

        public AsmOpCodeExprLegacy OpCode;

        public AsmSigExpr Sig;

    }
}