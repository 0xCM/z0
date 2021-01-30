//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public sealed class AsmOpCodeParser : WfService<AsmOpCodeParser, AsmOpCodeParser>
    {

        public bool Parse(AsmOpCodeExprLegacy src, out AsmOpCode dst)
        {
            dst = AsmOpCode.Empty;


            return false;
        }
    }
}