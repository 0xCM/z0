//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.IO;
    using System.Threading.Tasks;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a file exists
        /// </summary>
        /// <param name="src">The path for which existence will be tested</param>
        public static bool Exists(this FilePath src)
            => FileSystem.extant(src);

        /// <summary>
        /// Determines whether a directory exists
        /// </summary>
        /// <param name="src">The path for which existence will be tested</param>
        public static bool Exists(this FolderPath src)
            => FileSystem.extant(src);

       public static IEnumerable<FilePath> WithExtension(this IEnumerable<FilePath> src, FileExtension ext)
            => src.Where(path => path.Extension == ext);

        public static IEnumerable<FilePath> WithExtensions(this IEnumerable<FilePath> src, params FileExtension[] extensions)
            => src.Where(path => extensions.Any(e => e == path.Extension));

        public static bool Matches(this FilePath src, params string[] substrings)
            => substrings.Any(s => src.FullPath.Contains(s,StringComparison.InvariantCultureIgnoreCase));

        public static IEnumerable<FilePath> Include(this IEnumerable<FilePath> src, params string[] substrings)
            => src.Where(path => path.Matches(substrings));

        public static IEnumerable<FilePath> Exclude(this IEnumerable<FilePath> src, params string[] substrings)
            => src.Where(path => !path.Matches(substrings));
    }
}