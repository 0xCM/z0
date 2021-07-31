//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".poc")]
        Outcome Poc(CmdArgs args)
        {
            var result = Outcome.Success;
            var stubs = JmpStubs.create(Wf);
            stubs.Search();
            if(stubs.Create<ulong>(0))
            {
                var encoded = stubs.EncodeDispatch(0);
                Write(encoded.FormatHexData());
            }

            return result;
        }
    }
}