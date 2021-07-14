//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct TextFiles
    {
        static MsgPattern<Count,LineNumber,string> BadLineNumber => "BadLineNumber(counter{0} != line{1}, content{2})";

        public static Outcome<uint> CreateLinedDoc(FS.FilePath src, FS.FilePath dst, Pair<TextEncodingKind> encoding)
        {
            var outcome = Outcome.Success;
            using var reader = src.LineReader(encoding.Left);
            using var writer = dst.Writer(encoding.Right);
            var counter = 1u;
            while(reader.Next(out var line))
            {
                if(counter != line.LineNumber)
                {
                    var msg = BadLineNumber.Format(counter, line.LineNumber, line.Content);
                    outcome = (false,msg);
                    break;
                }
                writer.WriteLine(line);
                counter++;
            }
            return (true,counter-1);
        }

        [Op]
        public static LineCount linecount(FS.FilePath src)
            => (src, Lines.count(src.ReadBytes()));

        [Op]
        public static Index<LineCount> linecounts(ReadOnlySpan<FS.FilePath> src)
        {
            var dst = bag<LineCount>();
            iter(src, path => dst.Add(linecount(path)), true);
            return dst.ToArray().Sort();
        }
    }
}