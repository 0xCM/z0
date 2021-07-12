//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Root;

    partial class XFs
    {
        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        [Op]
        public static StreamReader Reader(this FS.FilePath src)
            => FS.reader(src, Encoding.UTF8);

        [Op]
        public static StreamReader Reader(this FS.FilePath src, Encoding encoding)
            => FS.reader(src, encoding);

        [Op]
        public static StreamReader Reader(this FS.FilePath src, TextEncodingKind encoding)
            => FS.reader(src, encoding);

        [Op]
        public static LineReader LineReader(this FS.FilePath src)
            => src.Reader(Encoding.UTF8).ToLineReader();

        [Op]
        public static LineReader LineReader(this FS.FilePath src, TextEncodingKind encoding)
            => src.Reader(encoding).ToLineReader();

        [Op]
        public static LineReader LineReader(this FS.FilePath src, Encoding encoding)
            => src.Reader(encoding).ToLineReader();

        [Op]
        public static StreamReader AsciReader(this FS.FilePath src)
            => FS.reader(src, Encoding.ASCII);

        [Op]
        public static LineReader AsciLineReader(this FS.FilePath src)
            => src.AsciReader().ToLineReader();

        [Op]
        public static StreamReader Utf8Reader(this FS.FilePath src)
            => FS.reader(src, Encoding.UTF8);

        [Op]
        public static LineReader Utf8LineReader(this FS.FilePath src)
            => src.Utf8Reader().ToLineReader();

        [Op]
        public static StreamReader Utf16Reader(this FS.FilePath src)
            => FS.reader(src, Encoding.Unicode);

        [MethodImpl(Inline), Op]
        public static LineReader ToLineReader(this StreamReader src)
            => new LineReader(src);
    }
}