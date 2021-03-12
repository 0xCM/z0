//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct FileSplitSpec
    {
        public FS.FilePath SourceFile {get;}

        public Count MaxLineCount {get;}

        public FS.FolderPath TargetFolder {get;}

        [MethodImpl(Inline)]
        public FileSplitSpec(FS.FilePath src, Count maxlines, FS.FolderPath dst)
        {
            SourceFile = src;
            MaxLineCount = maxlines;
            TargetFolder = dst;
        }
    }
}