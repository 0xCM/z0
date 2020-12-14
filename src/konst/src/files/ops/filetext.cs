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
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string filetext(FilePath src)
            => src.Exists ? File.ReadAllText(src.Name) : EmptyString;
    }
}