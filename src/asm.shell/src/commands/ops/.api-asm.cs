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
                ApiParsers.path(arg(args,0).Value, out var path);
                var pattern = path.MatchPattern();
            }

            if(result)
                Files(files);
            return result;
        }

        [CmdOp(".captured-asm")]
        Outcome ShowAsmCapture(CmdArgs args)
        {
            var part = arg(args,0);
            var outcome = ApiParsers.part(part.Value, out var id);
            if(outcome.Fail)
                return outcome;
            var pack = Wf.ApiPacks().Current();
            var files = pack.CapturedAsm(id);
            iter(files, file => Write(file.ToUri()));

            var spath = pack.AsmStatementSummary();
            var stats = spath.FileStats();
            var formatter = stats.Formatter();
            Write(formatter.FormatKvp(stats));

            return true;
        }

    }
}