//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ToolShimSpec
    {
        public string Name;

        public FS.FilePath Source;

        public FS.FolderPath OutDir;

        public FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public ToolShimSpec(string name, FS.FilePath src, FS.FolderPath dst)
        {
            Name = name;
            Source = src;
            OutDir = dst;
            TargetPath = OutDir + FS.file(Name, FS.Extensions.Exe);
        }
    }
}