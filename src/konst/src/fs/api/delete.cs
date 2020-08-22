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
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static void delete(FilePath src)
        {
            if(src.Exists)
                File.Delete(src.Name);
        }
    }
}