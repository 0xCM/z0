//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static RegClasses;

    partial class AsmCmdService
    {
        [CmdOp(".gen-reg-grids")]
        Outcome EmitRegGrids(CmdArgs args)
        {
            var dst = Gen().Path("regs",FS.Csv);
            var counter = 0u;
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.AsciWriter();
            counter += RegSets.Emit(RegSets.Grid(Gp, w8), writer);
            counter += RegSets.Emit(RegSets.Grid(Gp, w8,true), writer);
            counter += RegSets.Emit(RegSets.Grid(Gp, w16),writer);
            counter += RegSets.Emit(RegSets.Grid(Gp, w32),writer);
            counter += RegSets.Emit(RegSets.Grid(Gp, w64),writer);
            Wf.EmittedFile(flow,counter);
            return true;
        }
    }
}