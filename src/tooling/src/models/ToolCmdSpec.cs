//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct ToolCmdSpec : ITextual
    {
        /// <summary>
        /// The path to the tool executable
        /// </summary>
        public FS.FilePath ToolPath;

        /// <summary>
        /// The arguments to pass to the tool
        /// </summary>
        public Index<string> Args;

        /// <summary>
        /// The working folder, if any
        /// </summary>
        public FS.FolderPath WorkingDir;

        /// <summary>
        /// Environment variables to use, if any
        /// </summary>
        public NamedValues<string> EnvVars;
        public string Format()
            => string.Format("{0} {0}", ToolPath.Format(PathSeparator.BS), Args.Format());
    }
}