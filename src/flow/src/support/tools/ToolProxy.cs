//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Diagnostics;
    using System.IO;
    
    public struct ToolProxy
    {
        public string Name;

        public FilePath Source;

        public FolderPath OutDir;

        public ToolProxy(string name, FilePath src, FolderPath dst)
        {
            Name = name;
            Source = src;
            OutDir = dst;
        }

        public FilePath TargetPath 
            => OutDir + FileName.Define(Name, FileExtensions.Exe);
    }
}
