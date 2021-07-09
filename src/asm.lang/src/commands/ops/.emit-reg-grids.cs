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
       [CmdOp(".emit-reg-grids")]
        Outcome EmitRegGrids(CmdArgs args)
        {
            var dst = Workspace.Table("regs",FS.Csv);
            var counter = 0u;
            var flow = Wf.EmittingFile(dst);
            var grids = Wf.AsmRegGrids();
            using var writer = dst.AsciWriter();
            counter += grids.Emit(grids.Grid(GP, w8),writer);
            counter += grids.Emit(grids.Grid(GP, w8,true), writer);
            counter += grids.Emit(grids.Grid(GP, w16),writer);
            counter += grids.Emit(grids.Grid(GP, w32),writer);
            counter += grids.Emit(grids.Grid(GP, w64),writer);
            Wf.EmittedFile(flow,counter);
            return true;
        }
    }
}