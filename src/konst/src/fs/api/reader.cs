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
        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        [MethodImpl(Inline), Op]
        public static StreamReader reader(FS.FilePath src)
            => new StreamReader(src.Name.Format());
    }
}