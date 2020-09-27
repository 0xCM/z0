namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct ToolCommand
    {
        /// <summary>
        /// The path to the tool executable
        /// </summary>
        public readonly FS.FilePath Tool;

        /// <summary>
        /// The arguments to pass to the tool
        /// </summary>
        public readonly string Command;

        /// <summary>
        /// The working folder, if any
        /// </summary>
        public FS.FolderPath Root;

        /// <summary>
        /// Environment variables to use, if any
        /// </summary>
        public NamedValues<string> Vars;

        [MethodImpl(Inline)]
        public ToolCommand(FS.FilePath tool, string command, FS.FolderPath? root = null)
        {
            Tool = tool;
            Command = command;
            Root = root ?? FS.FolderPath.Empty;
            Vars = default;
        }
    }
}