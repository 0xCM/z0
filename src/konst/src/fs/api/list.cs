//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        public static ListedFiles list(Files src)        
            => new ListedFiles(src.Data.Mapi((i,x) => new ListedFile((uint)i,x.Name)));

        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        public static StreamReader reader(FS.FilePath src)
            => new StreamReader(src.Name.Format());

        /// <summary>
        /// Creates an overwriting and caller-disposed stream writer that targets a specified path
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter writer(FS.FilePath dst)
            => new StreamWriter(dst.CreateParentIfMissing().Name.Format(), false);

        public static StreamWriter writer(FS.FilePath dst, FileWriteMode mode)
            => new StreamWriter(dst.CreateParentIfMissing().Name.Format(), mode == FileWriteMode.Append);
    }
}