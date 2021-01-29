//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public sealed class AsmSigParser : WfService<AsmSigParser, AsmSigParser>
    {


        public bool Parse(AsmSigExpr src, out AsmSig dst)
        {
            dst = AsmSig.Empty;


            return false;
        }

    }

}