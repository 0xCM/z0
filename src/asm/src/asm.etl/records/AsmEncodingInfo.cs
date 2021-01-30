//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public struct AsmEncodingInfo
    {
        public AsmStatement Statement;

        public AsmSigExpr Sig;

        public AsmOpCodeExprLegacy OpCode;

        public BinaryCode Encoded;
    }
}