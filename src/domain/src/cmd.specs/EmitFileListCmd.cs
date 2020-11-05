//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd]
    public struct EmitFileListCmd : ICmdSpec<EmitFileListCmd>
    {
        public utf8 ListName;

        public FS.FolderPath SourceDir;

        public FS.FileExt[] FileKinds;

        public bool FileUriMode;

        public FS.FilePath TargetPath;

        public uint EmissionLimit;
    }
}