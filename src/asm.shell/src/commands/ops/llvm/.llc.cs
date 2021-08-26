//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".llc-sse2")]
        Outcome LlcSse2(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), "llc-sse2");

        [CmdOp(".llc-sse41")]
        Outcome LlcSse41(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), "llc-sse41");

        [CmdOp(".llc-avx")]
        Outcome LlcAvx(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), "llc-avx");

        [CmdOp(".llc-avx2")]
        Outcome LlcAvx2(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), "llc-avx2");

        [CmdOp(".llc-avx512")]
        Outcome LlcAvx512(CmdArgs args)
            => OmniScript.RunAsmScript(arg(args,0), "llc-avx512");
    }
}