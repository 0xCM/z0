//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    partial class ImageDataEmitter
    {
        static ReadOnlySpan<byte> RenderWidths
            => new byte[9]{60,16,16,12,12,60,16,16,16};

        public void EmitSectionHeaders()
        {
            EmitSectionHeaders(Archives.build(Wf));
        }

        public void EmitSectionHeaders(IBuildArchive src)
        {
            var svc = ImageDataEmitter.init(Wf);
            var db = Wf.Db();
            var dir = db.TableDir<ImageSectionHeader>();
            var cmd = CmdBuilder.EmitImageHeaders(src.DllFiles, db.Table(ImageSectionHeader.TableId, "dll"));
            svc.EmitSectionHeaders(cmd.Source, cmd.Target);
            cmd = CmdBuilder.EmitImageHeaders(src.ExeFiles, db.Table(ImageSectionHeader.TableId, "exe"));
            svc.EmitSectionHeaders(cmd.Source, cmd.Target);
        }

        public Outcome<Count> EmitSectionHeaders(FS.Files src, FS.FilePath dst)
        {
            var total = Count.Zero;
            var formatter = TableFormatter.row<ImageSectionHeader>(RenderWidths);
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

            return total;
        }

        static Outcome<uint> read(FS.FilePath path, out Span<ImageSectionHeader> target)
        {
            target = PeTableReader.headers(path);
            return (uint)target.Length;
        }
    }
}