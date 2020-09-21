//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FileOps
    {
        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string ReadText(FilePath src)
            => src.Exists ? File.ReadAllText(src.Name) : EmptyString;
    }
}