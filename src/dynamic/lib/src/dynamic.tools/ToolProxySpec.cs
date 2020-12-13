//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolProxySpec
    {
        public string Name;

        public FS.FilePath Source;

        public FS.FolderPath OutDir;

        public FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public ToolProxySpec(string name, FS.FilePath src, FS.FolderPath dst)
        {
            Name = name;
            Source = src;
            OutDir = dst;
            TargetPath = OutDir + FS.file(Name, FileExtensions.Exe);
        }
    }
}