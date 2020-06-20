//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    partial class XTend
    {
        public static IEnumerable<FilePath> WithExt(this IEnumerable<FilePath> src, FileExtension ext)
            => src.Where(path => path.Ext == ext);

        public static IEnumerable<FilePath> WithAnyExt(this IEnumerable<FilePath> src, params FileExtension[] extensions)
            => src.Where(path => extensions.Any(e => e == path.Ext));

        public static bool Matches(this FilePath src, params string[] substrings)
            => substrings.Any(s => src.Contains(s));

        public static IEnumerable<FilePath> Include(this IEnumerable<FilePath> src, params string[] substrings)
            => src.Where(path => path.Matches(substrings));

        public static IEnumerable<FilePath> Exclude(this IEnumerable<FilePath> src, params string[] substrings)
            => src.Where(path => !path.Matches(substrings));
    }
}