//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct ToolCmdSpec
    {
        /// <summary>
        /// The path to the tool executable
        /// </summary>
        public FS.FilePath CmdPath;

        /// <summary>
        /// The arguments to pass to the tool
        /// </summary>
        public ToolCmdArgs Args;

        /// <summary>
        /// The working folder, if any
        /// </summary>
        public FS.FolderPath WorkingDir;

        /// <summary>
        /// Environment variables to use, if any
        /// </summary>
        public NamedValues<string> Vars;

        public string Format()
            => string.Format("{0} {0}", CmdPath.Format(PathSeparator.BS), Args.Format());
    }
}