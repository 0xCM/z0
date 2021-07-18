//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    using static IntelSdm;

    partial class IntelSdmProcessor
    {
        public ReadOnlySpan<TextLine> ReadLinedSdm()
        {
            var dst = list<TextLine>();
            var src = LinedSdmPath();
            using var reader = src.LineReader(TextEncodingKind.Utf8);
            while(reader.Next(out var line))
                dst.Add(line);
            return dst.ViewDeposited();
        }

        public SortedSpan<UnicodeLine> MatchHeaderPatterns(VolDigit vol)
        {
            var dst = bag<UnicodeLine>();
            var log = ProcessLog("instructions");
            var lines = ReadLinedVolume(vol);
            var count = lines.Length;
            var flow = EmittingFile(log);
            using var logger = log.Writer();
            var matched = MatchPattern(lines, TableHeaderPatterns.HP(n0));
            iter(matched, x => dst.Add(x));
            matched = MatchPattern(lines, TableHeaderPatterns.HP(n1));
            iter(matched, x => dst.Add(x));
            matched = MatchPattern(lines, TableHeaderPatterns.HP(n2));
            iter(matched, x => dst.Add(x));
            matched = MatchPattern(lines, TableHeaderPatterns.HP(n3));
            iter(matched, x => dst.Add(x));

            var result = dst.ToSortedSpan();
            iter(result, r => logger.WriteLine(r));
            EmittedFile(flow, result.Length);
            return result;
        }

        ReadOnlySpan<UnicodeLine> MatchPattern(ReadOnlySpan<UnicodeLine> src, LinePattern pattern)
        {
            var flow = Running(string.Format("Searching {0} lines for a {1}-line pattern", src.Length, pattern.Length));
            var dst = list<UnicodeLine>();
            var tmp = list<UnicodeLine>();
            var count = src.Length;
            var parts = pattern.View;
            for(var i=0; i<count; i++)
            {
                for(var j=0; j<pattern.Length && i<count; j++, i++)
                {
                    ref readonly var line = ref skip(src,i);
                    if(line.Content.StartsWith(skip(parts,j)))
                        tmp.Add(line);
                    else
                    {
                        tmp.Clear();
                        break;
                    }
                }

                if(tmp.Count == pattern.Length)
                    dst.AddRange(tmp);

            }

            Ran(flow, string.Format("Matched {0} lines", dst.Count));
            return dst.ViewDeposited();
        }
    }
}