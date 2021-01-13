//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [Cmd(CmdName)]
    public struct ListFilesCmd : ICmdSpec<ListFilesCmd>
    {
        public const string CmdName = "list-files";

        public string ListName;

        public FS.FolderPath SourceDir;

        public FS.FileExt[] Extensions;

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

    partial class XCmd
    {
        [Op]
        public static ListFilesCmd ListFiles(this CmdBuilder builder, string name, FS.FolderPath src, params FS.FileExt[] kinds)
        {
            var cmd = new ListFilesCmd();
            cmd.ListName = name;
            cmd.SourceDir = src;
            cmd.Extensions = kinds;
            cmd.TargetPath = builder.Db.List(name, FileExtensions.Csv);
            cmd.ListFormat = ListFormatKind.Markdown;
            return cmd;
        }

        [Op]
        public static ref ListFilesCmd WithExt(this ref ListFilesCmd cmd, params FS.FileExt[] ext)
        {
            cmd.Extensions = ext;
            return ref cmd;
        }

        [Op]
        public static ref ListFilesCmd WithFormat(this ref ListFilesCmd cmd, ListFormatKind format)
        {
            cmd.ListFormat = format;
            return ref cmd;
        }

        [Op]
        public static ref ListFilesCmd WithLimit(this ref ListFilesCmd cmd, uint max)
        {
            cmd.EmissionLimit = max;
            return ref cmd;
        }
    }
}