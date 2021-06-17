//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static IntelSdm;

    partial class IntelSdmProcessor
    {

        void ProcessToc()
        {
            var vols = VolumeMarkers(1,4);
            var src = CombinedTocPath();
            using var reader = src.LineReader();
            var buffer = text.buffer();
            var dst = ProcessLog("toc.combined");
            using var writer = dst.Writer();
            var section = SectionNumber.Empty;
            var chapter = ChapterNumber.Empty;
            var table = TableNumber.Empty;
            var entry = TocTitle.Empty;
            while(reader.Next(out var line))
            {
                if(vols.CoversAny(line.Content))
                {
                    continue;
                }

                if(parse(line.Content, out chapter))
                {
                    render(line.LineNumber, chapter, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(line.Content, out section))
                {
                    render(line.LineNumber, section, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(line.Content, out entry))
                {
                    render(line.LineNumber, entry, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(line.Content, out table))
                {
                    render(line.LineNumber, table, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }
            }
        }
    }
}