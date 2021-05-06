//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct ListFilesCmd : ICmd<ListFilesCmd>
    {
        public const string CmdName = "list-files";

        public string ListName;

        public FS.FolderPath SourceDir;

        public Index<FS.FileExt> Extensions;

        public bool FileUriMode;

        public FS.FilePath TargetPath;

        public uint EmissionLimit;

        public ListFormatKind ListFormat;
    }

    public enum ListFormatKind : byte
    {
        None,

        Csv,

        Markdown
    }

    public static partial class XTend
    {
        [Op]
        public static ListFilesCmd ListFiles(this WfCmdBuilder builder, string name, FS.FolderPath src, params FS.FileExt[] kinds)
        {
            var cmd = new ListFilesCmd();
            cmd.ListName = name;
            cmd.SourceDir = src;
            cmd.Extensions = kinds;
            cmd.TargetPath = builder.Db.List(name, FS.Csv);
            cmd.ListFormat = ListFormatKind.Markdown;
            return cmd;
        }

        [Op]
        public static ref ListFilesCmd WithExt(this ref ListFilesCmd cmd, params FS.FileExt[] ext)
        {
            cmd.Extensions = ext;
            return ref cmd;
        }

    }
}