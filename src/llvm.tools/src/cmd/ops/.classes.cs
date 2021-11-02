//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    partial class LlvmCmd
    {
        [CmdOp(".classes")]
        Outcome Classes(CmdArgs args)
        {
            var result = Outcome.Success;
            var dst = LlvmPaths.TmpFile("classes", FS.Txt);
            using var writer = dst.AsciWriter();
            Db.Classes(writer);
            return result;
        }

        [CmdOp(".class-names")]
        Outcome ClassNames(CmdArgs args)
        {
            var result = Outcome.Success;
            var names = Db.ClassNames();
            iter(names, Write);
            return result;
        }

        [CmdOp(".def-names")]
        Outcome DefNames(CmdArgs args)
        {
            var result = Outcome.Success;
            var names = Db.DefNames();
            iter(names, Write);
            return result;
        }

        [CmdOp(".fields")]
        Outcome Fields(CmdArgs args)
        {
            var result = Outcome.Success;
            if(args.Length == 2)
            {
                DataParser.parse(arg(args,0).Value, out uint offset);
                DataParser.parse(arg(args,1).Value, out uint length);
                var fields = Db.Fields(offset,length);
                iter(fields, f => Write(f.Format()));
            }
            else
            {
                var types = hashset<string>();
                var defs = list<Identifier>();
                Db.Fields(provider => {
                    defs.Add(provider.EntityName);
                });

                iter(defs, d => Write(d));
            }
            return result;
        }

        FS.Files TdFiles()
            => FileArchives.filtered(LlvmPaths.LlvmRoot, FS.ext("td")).Files().Array();

        FS.FilePath EmitTdLinks()
        {
            var dst = LlvmPaths.TmpFile("tablegen-defs", FS.Md);
            using var writer = dst.AsciWriter();
            iter(TdFiles(), f => writer.WriteLine(f.ToUri().MarkdownBullet()));
            return dst;
        }

        [CmdOp(".td-markdown")]
        Outcome TdMd(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = EmitTdLinks();
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                Write(line.Format());
            }
            return result;
        }

        [CmdOp(".td-rel")]
        Outcome TdRel(CmdArgs args)
        {
            var result = Outcome.Success;
            var sources = TdFiles().View;
            var count = sources.Length;
            var view = LlvmPaths.LlvmSourceView();
            for(var i=0; i<count; i++)
            {
                ref readonly var srcpath = ref skip(sources,i);
                var relative = srcpath.Relative(LlvmPaths.LlvmRoot);
                var linkpath = view + relative;
                var link = FS.symlink(linkpath, srcpath, true);
                link.OnFailure(Error).OnSuccess(Write);
            }

            return result;
        }
    }
}