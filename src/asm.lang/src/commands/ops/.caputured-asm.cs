//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".captured-asm")]
        Outcome ShowAsmCapture(CmdArgs args)
        {
            var part = arg(args,0);
            var outcome = ApiPartIdParser.parse(part.Value, out var id);
            if(outcome.Fail)
                return outcome;
            var packs = Wf.ApiPacks();
            var pack = packs.Last();
            var files = pack.CapturedAsm(id);
            iter(files, file => Write(file.ToUri()));

            var spath = pack.AsmStatementSummary();
            var stats = spath.FileStats();
            var formatter = stats.Formatter();
            Write(formatter.FormatKvp(stats));

            return true;
        }

        [CmdOp(".process-statements")]
        Outcome ProcessStatementIndex(CmdArgs args)
        {
            var counter = 0u;
            var dst = Db.AppLog("statements.rex", FS.Csv);
            var packs = Wf.ApiPacks();
            var archive = packs.Archive();
            var path = archive.StatementIndexPath();
            var flow = Wf.Running(string.Format("Loading statement index from {0}", path.ToUri()));
            var index = AsmEtl.LoadStatementIndex(path);
            var count = index.Length;
            Wf.Ran(flow, string.Format("Loded {0} statement records", index.Length));

            var collection = list<AsmIndex>();
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(index,i);
                if(AsmQuery.HasRexPrefix(s.OpCode))
                {
                    collection.Add(s);
                }
            }

            var sorted = @readonly(collection.ToArray().OrderBy(x => x.Encoded));
            Emit(sorted, AsmIndex.RenderWidths, dst);
            return true;
        }
    }
}