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

        public void EmitRuntimeHeaders()
        {
            EmitImageHeaders(Archives.runtime(Wf));
        }

        public void EmitImageHeaders(IRuntimeArchive src)
        {
            var db = Wf.Db();
            var dir = db.TableDir<ImageSectionHeader>();
            EmitImageHeaders(src.DllFiles, db.Table(ImageSectionHeader.TableId, "dll"));
            EmitImageHeaders(src.ExeFiles, db.Table(ImageSectionHeader.TableId, "exe"));
        }

        public Outcome<Count> EmitImageHeaders(FS.Files src, FS.FilePath dst)
        {
            var total = Count.Zero;
            var formatter = Tables.formatter<ImageSectionHeader>(SectionHeaderWidths);
            var flow = Wf.EmittingTable<ImageSectionHeader>(dst);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in src)
            {
                var result = read(file, out Index<ImageSectionHeader> headers);
                if(result)
                {
                    var count = result.Data;
                    var view = headers.View;
                    for(var i=0u; i<count; i++)
                        writer.WriteLine(formatter.Format(skip(view,i)));

                    total += count;
                }
            }
            Wf.EmittedTable(flow, total);

            return total;
        }

        static Outcome<uint> read(FS.FilePath path, out Index<ImageSectionHeader> target)
        {
            target = PeTableReader.headers(path);
            return (uint)target.Length;
        }
    }
}