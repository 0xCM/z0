//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".process-global-asm")]
        Outcome ProcessGlobalAsm(CmdArgs args)
        {
            var counter = 0u;
            var dst = Db.AppLog("statements.rex", FS.Csv);
            var archive = Wf.ApiPacks().Archive();
            var path = archive.StatementIndexPath();
            var flow = Wf.Running(string.Format("Loading statement index from {0}", path.ToUri()));
            var index = AsmEtl.LoadGlobalAsm(path);
            var count = index.Length;
            Wf.Ran(flow, string.Format("Loded {0} statement records", index.Length));

            var collection = list<AsmGlobal>();
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(index,i);
                if(AsmQuery.HasRexPrefix(s.OpCode))
                {
                    collection.Add(s);
                }
            }

            var sorted = @readonly(collection.ToArray().OrderBy(x => x.Encoded));
            EmitRows(sorted, AsmGlobal.RenderWidths, dst);
            return true;
        }
    }
}