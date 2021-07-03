//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class IntelSdmProcessor
    {
        Outcome EmitCharMaps()
        {
            EmitDefaultCharMap();
            LogUnmappedChars();
            return true;
        }

        void LogUnmappedChars()
        {
            LogUnmappedChars(SourceDocPath());
        }

        void EmitDefaultCharMap()
        {
            var charmap = CharMaps.editor(Utf16Encoding).Seal();
            var dst = CharMapPath();
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var mapcount = CharMaps.emit(charmap, writer);
            Wf.EmittedFile(emitting, mapcount);
        }

        SortedReadOnlySpan<Paired<Hex16,char>> FindUnmappedChars(FS.FilePath src)
        {
            var flow = Wf.Running(string.Format("Searching {0} for unmapped characters", src.ToUri()));
            var charmap = CharMaps.editor(Utf16Encoding).Seal();
            var unmapped = hashset<char>();

            using var reader = src.LineReader();
            while(reader.Next(out var line))
                CharMaps.unmapped(charmap, line.Data, unmapped);

            var pairs = unmapped.Map(x => paired((Hex16)x,x)).OrderBy(x => x.Left).ToReadOnlySpan();
            var data = Spans.sorted(pairs);
            Wf.Ran(flow, string.Format("Found {0} unmapped characters", data.Length));
            return data;
        }

        void LogUnmappedChars(FS.FilePath src)
        {
            var unmapped = FindUnmappedChars(src);
            var pairs = unmapped.View.Map(CharMaps.format);
            var delimited = pairs.Delimit(Chars.Comma).Format();
            var description = string.Format("Unmapped:{0}", RP.embrace(delimited));
            Wf.Row(description);
        }
    }
}