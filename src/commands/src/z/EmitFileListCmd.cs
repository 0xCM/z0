//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitFileListCmd : ICmdSpec<EmitFileListCmd>
    {
        [Op]
        public static EmitFileListCmd specify(IWfShell wf, string name, FS.FolderPath src, params FS.FileExt[] kinds)
        {
            var cmd = new EmitFileListCmd();
            cmd.ListName = name;
            cmd.SourceDir = src;
            cmd.FileKinds = kinds;
            cmd.TargetPath = wf.Db().Doc(name, ArchiveFileKinds.Csv);
            return cmd;
        }

        public const string CmdName = "emit-file-list";

        public string ListName;

        public FS.FolderPath SourceDir;

        public FS.FileExt[] FileKinds;

        public bool FileUriMode;

        public FS.FilePath TargetPath;

        public uint EmissionLimit;
    }
}