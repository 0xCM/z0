//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string ReadText(this FS.FilePath src)
            => src.Exists ? File.ReadAllText(src.Name) : EmptyString;

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] ReadLines(this FS.FilePath src)
            => src.Exists ? File.ReadAllLines(src.Name) : sys.empty<string>();

        /// <summary>
        /// Reads the full content of a file into a byte array
        /// </summary>
        /// <param name="src">The file path</param>
        public static byte[] ReadBytes(this FS.FilePath src)
            => src.Exists ? File.ReadAllBytes(src.Name) : sys.empty<byte>();

        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        public static StreamReader Reader(this FS.FilePath src)
            => FS.reader(src);

        public static FS.FolderPath Normalize(this FS.FolderPath src)
            => new FS.FolderPath(src.Name.Replace(Chars.BSlash, Chars.FSlash));
    }
}