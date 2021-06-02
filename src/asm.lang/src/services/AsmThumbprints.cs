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
        public ReadOnlySpan<AsmThumbprint> Load()
            => Load(DefaultPath());

        public ReadOnlySpan<AsmThumbprint> Load(FS.FilePath src)
        {
            var dst = list<AsmThumbprint>();
            var tpPipe = AsmThumbprints.create(Wf);
            using var reader = src.Reader();
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine();
                var statement = asm.statement(data.LeftOfFirst(Chars.Semicolon));
                var tpResult = AsmParser.thumbprint(data, out var thumbprint);
                if(tpResult)
                    dst.Add(thumbprint);
                else
                    Wf.Error(tpResult.Message);
            }
            return dst.ToArray();
        }

        public ReadOnlySpan<TextLine> Emit(SortedSpan<AsmEncodingInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            var emitting = Wf.EmittingFile(dst);
            var lines = span<TextLine>(count);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                var content = AsmRender.thumbprint(skip(src,i));
                writer.WriteLine(content);
                seek(lines,i) = (i,content);
            }
            Wf.EmittedFile(emitting, count);
            return lines;
        }

        public ReadOnlySpan<TextLine> Emit(SortedSpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var count = src.Length;
            var emitting = Wf.EmittingFile(dst);
            var lines = span<TextLine>(count);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                var content = AsmRender.thumbprint(skip(src,i), true);
                writer.WriteLine(content);
                seek(lines,i) = (i,content);
            }
            Wf.EmittedFile(emitting, count);
            return lines;
        }

        public SortedSpan<AsmThumbprint> Emit(ReadOnlySpan<AsmApiStatement> src, FS.FilePath dst)
        {
            var distinct = CollectDistinct(src);
            Emit(distinct, dst);
            return distinct;
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
            var src = Load();
            var count = src.Length;
            using var log = ShowLog(FS.Asm, "thumbprints");
            for(var i=0; i<count; i++)
                log.Show(AsmRender.format(skip(src,i)));
        }

        public SortedSpan<AsmThumbprint> CollectDistinct(ReadOnlySpan<AsmApiStatement> src)
        {
            var distinct = hashset<AsmThumbprint>();
            iter(src, s => distinct.Add(asm.thumbprint(s)));
            return distinct.ToArray().ToSortedSpan();
        }

        FS.FilePath DefaultPath()
            => Db.TableDir<AsmApiStatement>() + FS.file("thumbprints", FS.Asm);
    }
}