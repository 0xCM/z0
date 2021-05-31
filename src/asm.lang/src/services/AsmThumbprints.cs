//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static core;

    public sealed class AsmThumbprints : AppService<AsmThumbprints>
    {
        public Index<AsmThumbprint> LoadThumbprints()
            => LoadThumbprints(DefaultPath());

        public Index<AsmThumbprint> LoadThumbprints(FS.FilePath src)
        {
            var dst = root.list<AsmThumbprint>();
            var tpPipe = AsmThumbprints.create(Wf);
            using var reader = src.Reader();
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine();
                var statement = AsmCore.statement(data.LeftOfFirst(Chars.Semicolon));
                var tpResult = AsmParser.thumbprint(data, out var thumbprint);
                if(tpResult)
                    dst.Add(thumbprint);
                else
                    Wf.Error(tpResult.Message);
            }
            return dst.ToArray();
        }

        public void EmitThumbprints(ReadOnlySpan<AsmThumbprint> src)
        {
            var dst = DefaultPath();
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRender.format(skip(src,i)));
            Wf.EmittedFile(flow, count);
        }

        public void EmitThumbprints(ReadOnlySpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRender.format(skip(src,i)));
            Wf.EmittedFile(flow, count);
        }

        public void ShowThumprintCatalog()
        {
            var src = LoadThumbprints().View;
            var count = src.Length;
            using var log = ShowLog(FS.Asm, "thumbprints");
            for(var i=0; i<count; i++)
                log.Show(AsmRender.format(skip(src,i)));
        }

        public void EmitThumbprints(Index<AsmApiStatement> src)
        {
            var distinct = root.hashset<AsmThumbprint>();
            root.iter(src, s => distinct.Add(asm.thumbprint(s)));
            Wf.Status(Msg.CollectedThumbprints.Format(distinct.Count, src.Count));
            EmitThumbprints(distinct.ToArray());
        }

        FS.FilePath DefaultPath()
            => Db.TableDir<AsmApiStatement>() + FS.file("thumbprints", FS.Asm);
    }
}