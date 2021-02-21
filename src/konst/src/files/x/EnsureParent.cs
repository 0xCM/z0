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
        public static FS.FilePath EnsureParentExists(this FS.FilePath src)
        {
            if(src.IsEmpty)
                root.@throw("The source path is unspecified");

            var dir = Path.GetDirectoryName(src.Name.Format());
            if(!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return src;
        }

        public static FS.FolderPath EnsureExists(this FS.FolderPath src)
        {
            if(!src.Exists)
                src.Create();
            return src;
        }
    }
}