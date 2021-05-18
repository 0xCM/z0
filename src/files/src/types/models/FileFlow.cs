//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileFlow : IFileFlow, IDataFlow<FS.FilePath,FS.FilePath>
    {
        public FS.FilePath SourcePath {get;}

        public FileType SourceType {get;}

        public FS.FilePath TargetPath {get;}

        public FileType TargetType {get;}

        [MethodImpl(Inline)]
        public FileFlow(FS.FilePath src, FileType srcType,  FS.FilePath dst, FileType dstType)
        {
            SourcePath = src;
            SourceType = srcType;
            TargetPath = dst;
            TargetType = dstType;
        }

        public FS.FilePath Source
        {
            [MethodImpl(Inline)]
            get => SourcePath;
        }

        public FS.FilePath Target
        {
            [MethodImpl(Inline)]
            get => TargetPath;
        }

    }
}