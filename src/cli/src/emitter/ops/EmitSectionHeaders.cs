//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial class ImageDataEmitter
    {
        static ReadOnlySpan<byte> SectionHeaderWidths
            => new byte[9]{60,16,16,12,12,60,16,16,16};

        public void EmitImageHeaders()
        {
            EmitImageHeaders(Archives.build(Wf));
        }

        public void EmitImageHeaders(IBuildArchive src)
        {
            var svc = ImageDataEmitter.create(Wf);
            var db = Wf.Db();
            var dir = db.TableDir<ImageSectionHeader>();
            var cmd = CmdBuilder.EmitImageHeaders(src.DllFiles, db.Table(ImageSectionHeader.TableId, "dll"));
            svc.EmitImageHeaders(cmd.Source, cmd.Target);
            cmd = CmdBuilder.EmitImageHeaders(src.ExeFiles, db.Table(ImageSectionHeader.TableId, "exe"));
            svc.EmitImageHeaders(cmd.Source, cmd.Target);
        }

        public Outcome<Count> EmitImageHeaders(FS.Files src, FS.FilePath dst)
        {
            var total = Count.Zero;
            var formatter = TableFormatter.row<ImageSectionHeader>(SectionHeaderWidths);
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in src)
            {
                var result = read(file, out Span<ImageSectionHeader> headers);
                if(result)
                {
                    var count = result.Data;
                    for(var i=0u; i<count; i++)
                        writer.WriteLine(formatter.FormatRow(skip(headers,i)));

                    total += count;
                }
            }
            Wf.EmittedFile(flow, total);

            return total;
        }

        static Outcome<uint> read(FS.FilePath path, out Span<ImageSectionHeader> target)
        {
            target = PeTableReader.headers(path);
            return (uint)target.Length;
        }
    }
}