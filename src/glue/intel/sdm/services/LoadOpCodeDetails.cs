//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class IntelSdm
    {
        public Outcome<Index<SdmOpCodeDetail>> LoadOpCodeDetails()
        {
            var result = Outcome.Success;
            var dst = sys.empty<SdmOpCodeDetail>();
            var src = Project().Subdir("imports") + Tables.filename<SdmOpCodeDetail>();
            var lines = src.ReadLines(TextEncodingKind.Unicode).View;
            result = TextGrids.load(lines, out var grid);
            if(result.Fail)
                return result;
            var count = grid.RowCount;
            dst = alloc<SdmOpCodeDetail>(count);
            result = AsmParser.rows(grid, dst);
            if(result.Fail)
                return result;
            else
                return (true,dst);
        }
    }
}