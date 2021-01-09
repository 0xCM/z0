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
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] lines(FilePath src)
            => src.Exists ? File.ReadAllLines(src.Name) : sys.empty<string>();
    }
}