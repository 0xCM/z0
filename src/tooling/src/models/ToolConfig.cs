//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a configuration for an identified tool
    /// </summary>
    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct ToolConfig : IRecord<ToolConfig>
    {
        public const string TableId = "tool.configs";

        public const byte FieldCount = 8;

        /// <summary>
        /// The tool identifier
        /// </summary>
        public ToolId ToolId;

        /// <summary>
        /// The executable filename without the directory path
        /// </summary>
        public FS.FileName ToolExe;

        /// <summary>
        /// The tool installation directory where the <see cref='ToolExe'/> is found
        /// </summary>
        public FS.FolderPath InstallBase;

        /// <summary>
        /// The full path to the tool, computed from the <see cref='ToolExe'/> and <see cref='InstallBase'/>
        /// </summary>
        public FS.FilePath ToolPath;

        /// <summary>
        /// The toolspace directory
        /// </summary>
        public FS.FolderPath ToolHome;

        /// <summary>
        /// The tool log directory with default location {ToolHome}/logs
        /// </summary>
        public FS.FolderPath ToolLogs;

        /// <summary>
        /// The tool documentation directory with default location {ToolHome}/docs
        /// </summary>
        public FS.FolderPath ToolDocs;

        /// <summary>
        /// The tool script directory with default location {ToolHome}/scripts
        /// </summary>
        public FS.FolderPath ToolScripts;
    }
}