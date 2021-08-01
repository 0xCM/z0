//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-asm-data")]
        Outcome ApiAsmData(CmdArgs args)
        {
            var result = Outcome.Success;
            var archive = Wf.ApiPacks().Archive();
            var files = array<FS.FilePath>();
            if(args.Count == 0)
                files = archive.StatementRoot().Files(FS.Csv,true);
            else
            {
                result = ApiParsers.part(arg(args,0).Value, out var part);
                if(result)
                    files = (archive.StatementRoot() + FS.folder(part.Format())).Files(FS.Csv);
            }

            var count = files.Length;
            if(result && files.Length != 0)
            {
                ref readonly var src = ref first(files);
                for(var i=0; i<count; i++)
                {
                    ref readonly var file = ref skip(src,i);
                    var statements = AsmTables.LoadHostStatements(file);
                    Write(string.Format("Absorbed {0} {1} statements", statements.Count, file));
                }
                Files(files,false);
            }
            return result;
        }
    }
}