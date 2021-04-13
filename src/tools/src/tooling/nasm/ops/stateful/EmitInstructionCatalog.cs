//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    partial class Nasm
    {
        public Index<NasmInstruction> EmitInstructionCatalog(FS.FilePath dst)
        {
            var src = ParseInstuctionAssets();
            var count = src.Length;
            if(count != 0)
            {
                var flow = Wf.EmittingTable<NasmInstruction>(dst);
                var emitted = Tables.emit(src.View, dst);
                Wf.EmittedTable(flow, emitted);
                return src;
            }
            else
                return Index<NasmInstruction>.Empty;
        }

        public Index<NasmInstruction> EmitInstructionCatalog()
            => EmitInstructionCatalog(Db.CatalogTable<NasmInstruction>("asm"));
    }
}