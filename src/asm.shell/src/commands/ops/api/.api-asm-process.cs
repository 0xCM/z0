//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-asm-process")]
        Outcome ProcessApiAsm(CmdArgs args)
        {
            var counter = 0u;
            var rexdst = OutWs().QueryOut("statements.rex", FS.Csv);
            var archive = Wf.ApiPacks().Archive();
            var path = archive.StatementIndexPath();
            var flow = Wf.Running(string.Format("Loading statement index from {0}", path.ToUri()));
            var index = AsmEtl.LoadGlobalAsm(path);
            var count = index.Length;
            Wf.Ran(flow, string.Format("Loded {0} statements", index.Length));

            var rex = list<AsmGlobal>();
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(index,i);
                if(AsmOpCodes.HasRexPrefix(record.OpCode))
                    rex.Add(record);
            }

            var sorted = @readonly(rex.ToArray().OrderBy(x => x.Encoded));
            EmitRows(sorted, AsmGlobal.RenderWidths, rexdst);
            return true;
        }
    }
}