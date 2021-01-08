//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    partial struct FS
    {
        /// <summary>
        /// Creates an overwriting and caller-disposed stream writer that targets a specified path
        /// </summary>
        /// <param name="dst">The file path</param>
        [MethodImpl(Inline), Op]
        public static StreamWriter writer(FS.FilePath dst)
            => new StreamWriter(dst.EnsureParent().Name.Format(), false);

        [MethodImpl(Inline), Op]
        public static StreamWriter writer(FS.FilePath dst, FileWriteMode mode)
            => new StreamWriter(dst.EnsureParent().Name.Format(), mode == FileWriteMode.Append);
    }
}