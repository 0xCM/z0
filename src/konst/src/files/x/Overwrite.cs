//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial class XFs
    {
        public static void Overwrite(this FS.FilePath dst, params string[] src)
        {
            using var writer = new StreamWriter(dst.EnsureParent().Name, false);
            foreach(var line in src)
                writer.WriteLine(line);
        }
    }
}