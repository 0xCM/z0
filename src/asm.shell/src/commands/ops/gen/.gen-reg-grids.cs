//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static AsmCodes;

    partial class AsmCmdService
    {
        [CmdOp(".gen-reg-grids")]
        Outcome EmitRegGrids(CmdArgs args)
        {
            var dst = GenWs().Path("regs",FS.Csv);
            var counter = 0u;
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.AsciWriter();
            counter += RegSets.Emit(RegSets.Grid(GP, w8), writer);
            counter += RegSets.Emit(RegSets.Grid(GP, w8,true), writer);
            counter += RegSets.Emit(RegSets.Grid(GP, w16),writer);
            counter += RegSets.Emit(RegSets.Grid(GP, w32),writer);
            counter += RegSets.Emit(RegSets.Grid(GP, w64),writer);
            Wf.EmittedFile(flow,counter);
            return true;
        }
    }
}