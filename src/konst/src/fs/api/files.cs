//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static Seq<FilePath> files(FolderPath src, bool recurse)
            => files(src, "*.*", recurse);

        [MethodImpl(Inline), Op]
        public static Seq<FilePath> files(FolderPath src, bool recurse, FileExt ext)
            => files(src, ext.SearchPattern, recurse);

        [MethodImpl(Inline), Op]
        public static Seq<FilePath> files(FolderPath src, bool recurse, params FileExt[] ext)
            => files(src, pattern(ext), recurse);

        [MethodImpl(Inline), Op]
        public static Seq<FilePath> files(FolderPath src, string pattern, bool recurse)
            => EnumerateFiles(src, pattern, recurse);

        static Seq<FilePath> EnumerateFiles(FolderPath src, string pattern, bool recurse, bool casematch = false)
            => missing(src) ? Seq.empty<FilePath>() : Seq.from(from f in Directory.EnumerateFiles(src.Name, pattern, SearchOptions(recurse, casematch)) select path(f));

        [MethodImpl(Inline)]
        static EnumerationOptions SearchOptions(bool recurse, bool casematch = false, FileAttributes? skip = null)
            => new EnumerationOptions{
                RecurseSubdirectories = recurse,
                AttributesToSkip = skip ?? 0,
                MatchCasing = casematch ? MatchCasing.CaseSensitive : MatchCasing.CaseInsensitive,
                MatchType = MatchType.Win32
            };
    }
}