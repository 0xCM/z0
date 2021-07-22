//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asci-bytes")]
        Outcome AsciBytes(CmdArgs args)
        {
            var name = arg(args,0).Value;
            var content = arg(args,1).Value;
            var bytes = Wf.AsciBytes();
            var spec = bytes.DefineAsciBytes(name, content);
            var data = spec.Format();
            Write(data);
            return true;
        }
    }
}