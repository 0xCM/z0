//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static SdmModels;

    partial class IntelSdm
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

        public Outcome EmitTocRecords()
        {
            var result = Outcome.Success;
            var flow = Wf.Running();
            var vols = VolumeMarkers(1,4);
            var src = TocImportPath();
            if(!src.Exists)
            {
                result = (false,FS.missing(src));
                Wf.Error(result.Message);
                return result;
            }

            var encoding = TextEncodingKind.Unicode;
            using var reader = src.LineReader(encoding);
            var buffer = text.buffer();
            var dst = ProcessLog("toc.combined");
            using var writer = dst.Writer(encoding);
            var cn = ChapterNumber.Empty;
            var tn = TableNumber.Empty;
            var title = TocTitle.Empty;
            var entry = TocEntry.Empty;
            var entries = list<TocEntry>();
            var _snbuffer = span<SectionNumber>(1);
            ref var _sn = ref first(_snbuffer);
            _sn = SectionNumber.Empty;
            while(reader.Next(out var line))
            {
                var content = line.Content;
                var number = line.LineNumber;
                if(vols.CoversAny(content))
                {
                    writer.WriteLine(string.Format("{0}:{1}", number, content));
                    continue;
                }

                if(parse(content, out cn))
                {
                    render(number, cn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(content, out SectionNumber sn))
                {
                    _sn = sn;
                    render(number, _sn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(content, out title))
                {
                    entry = toc(_sn, title);
                    entries.Add(entry);
                    render(number, entry, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }

                if(parse(content, out tn))
                {
                    render(number, tn, buffer);
                    writer.WriteLine(buffer.Emit());
                    continue;
                }
            }

            var rowcount = TableEmit(entries.ViewDeposited(), TocEntryTable());
            Wf.Ran(flow, string.Format("Collected {0} toc entries", rowcount));
            return result;
        }
    }
}