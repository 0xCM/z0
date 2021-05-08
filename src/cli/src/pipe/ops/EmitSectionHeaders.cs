//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;
    using static ImageRecords;
    using static PeRecords;

    partial class ImageMetaPipe
    {
        static ReadOnlySpan<byte> SectionHeaderWidths
            => new byte[9]{60,16,16,12,12,60,16,16,16};

        public void EmitSectionHeaders()
        {
            EmitSectionHeaders(WfRuntime.RuntimeArchive(Wf));
        }

        public void EmitSectionHeaders(IRuntimeArchive src)
        {
            var db = Wf.Db();
            var dir = db.TableDir<SectionHeaderInfo>();
            EmitSectionHeaders(src.DllFiles, db.Table(SectionHeaderInfo.TableId, "dll"));
            EmitSectionHeaders(src.ExeFiles, db.Table(SectionHeaderInfo.TableId, "exe"));
        }

        public Outcome<Count> EmitSectionHeaders(FS.Files src, FS.FilePath dst)
        {
            var total = Count.Zero;
            var formatter = Tables.formatter<SectionHeaderInfo>(SectionHeaderWidths);
            var flow = Wf.EmittingTable<SectionHeaderInfo>(dst);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in src)
            {
                if(!ImageMetadata.valid(file))
                    continue;

                using var reader = ImageMetadata.reader(file);
                var headers = reader.ReadSectionHeaderInfo();
                var count = headers.Length;
                var view = headers.View;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(view,i)));

                total += count;
            }
            Wf.EmittedTable(flow, total);

            return total;
        }
    }
}