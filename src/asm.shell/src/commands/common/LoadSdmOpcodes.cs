//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        Outcome LoadSdmOpcodes(out SdmOpCodeDetail[] dst)
        {
            var result = Outcome.Success;
            var etl = AsmEtl.create(Wf);
            var srcpath = TableWs().Table<SdmOpCodeDetail>();
            result = etl.LoadSdmOpCodes(srcpath, out dst);
            State.SdmOpCodes(dst);
            return result;
        }
    }
}