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
        string VolumeMarker(byte vol)
            => string.Format("Vol. {0}", vol);

        Strings VolumeMarkers(byte min, byte max)
        {
            var dst = Strings.create();
            for(var i=min; i<=max; i++)
                dst.Add(VolumeMarker(i));
            return dst;
        }

        Outcome EmitTocAnalysis()
        {
            var result = Outcome.Success;
            var flow = Wf.Running();
            var vols = VolumeMarkers(1,4);
            var src = CombinedTocPath();
            if(!src.Exists)
            {
                result = (false,FS.missing(src));
                Wf.Error(result.Message);
                return result;
            }
            using var reader = src.LineReader();
            var buffer = text.buffer();
            var dst = ProcessLog("toc.combined");
            using var writer = dst.Writer();
            var sn = SectionNumber.Empty;
            var cn = ChapterNumber.Empty;
            var tn = TableNumber.Empty;
            var title = TocTitle.Empty;
            var entry = TocEntry.Empty;
            var _sn = SectionNumber.Empty;
            var entries = list<TocEntry>();
            while(reader.Next(out var line))
            {
                if(vols.CoversAny(line.Content))
                {
                    writer.WriteLine(string.Format("{0}:{1}", line.LineNumber, line.Content));
                    continue;
                }

                if(parse(line.Content, out cn))
                {
                    IntelSdm.render(line.LineNumber, cn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(line.Content, out sn))
                {
                    IntelSdm.render(line.LineNumber, sn, buffer);
                    _sn = sn;
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(line.Content, out title))
                {
                    entry = toc(_sn, title);
                    entries.Add(entry);
                    render(line.LineNumber, entry, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(line.Content, out tn))
                {
                    render(line.LineNumber, tn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }
            }

            Wf.Ran(flow, string.Format("Collected {0} toc entries", entries.Count));
            return result;
        }
    }
}