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

    partial struct FS
    {
        [Op]
        public static string SearchPattern(FS.FileExt[] src)
            => string.Join(";*.", src.Select(e => e.Name));

        /// <summary>
        /// Creates an overwriting and caller-disposed stream writer that targets a specified path
        /// </summary>
        /// <param name="dst">The file path</param>
        [MethodImpl(Inline), Op]
        public static StreamWriter writer(FS.FilePath dst)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), false);

        [MethodImpl(Inline), Op]
        public static StreamWriter writer(FS.FilePath dst, Encoding encoding)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), false, encoding);

        [MethodImpl(Inline), Op]
        public static StreamWriter writer(FS.FilePath dst, FileWriteMode mode)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), mode == FileWriteMode.Append);

        [MethodImpl(Inline), Op]
        public static StreamWriter writer(FS.FilePath dst, FileWriteMode mode, Encoding encoding)
            => new StreamWriter(dst.EnsureParentExists().Name.Format(), mode == FileWriteMode.Append, encoding);
    }
}