//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Root;
    using static core;

    partial struct FS
    {
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