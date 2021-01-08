//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public struct LlvmConfig
    {
        public FS.FolderPath SourceRoot;

        public FS.FolderPath BuildRoot;

        public static LlvmConfig create(FS.FolderPath SourceRoot, FS.FolderPath? BuildRoot = null)
        {
            var dst = new LlvmConfig();
            dst.SourceRoot = SourceRoot;
            dst.BuildRoot = BuildRoot ?? (dst.SourceRoot + FS.folder("build"));
            return dst;
        }
    }
}