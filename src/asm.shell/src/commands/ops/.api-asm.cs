//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-asm")]
        Outcome ApiAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var archive = Wf.ApiPacks().Archive();
            var files = array<FS.FilePath>();
            if(args.Count == 0)
                files = archive.AsmRoot().Files(FS.Asm,true);
            else
            {
                var a = arg(args,0).Value;
                var i = text.index(a,Chars.FSlash);
                if(i > 0)
                {
                    result = ApiParsers.part(text.left(a,i), out var part);
                    if(result)
                    {
                        var uri = new ApiHostUri(part, text.right(a,i));
                        files = array(archive.Statements(uri));
                    }
                }
                else
                {
                    files = (archive.AsmRoot() + FS.folder(a)).Files(FS.Asm,true);
                }
            }
            if(result)
                Files(files);
            return result;
        }

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
            var pipes = Wf.AsmDataPipes();
            if(result && files.Length != 0)
            {
                ref readonly var src = ref first(files);
                for(var i=0; i<count; i++)
                {
                    ref readonly var file = ref skip(src,i);
                    var statements = pipes.LoadHostStatements(file);
                    Write(string.Format("Absorbed {0} {1} statements", statements.Count, file));
                }
                Files(files,false);
            }
            return result;
        }

        [CmdOp(".captured-asm")]
        Outcome ShowAsmCapture(CmdArgs args)
        {
            var part = arg(args,0);
            var outcome = ApiParsers.part(part.Value, out var id);
            if(outcome.Fail)
                return outcome;

            var files = ApiPack.CapturedAsm(id);
            iter(files, file => Write(file.ToUri()));

            var spath = ApiPack.AsmStatementSummary();
            var stats = spath.FileStats();
            var formatter = stats.Formatter();
            Write(formatter.FormatKvp(stats));

            return true;
        }
    }
}