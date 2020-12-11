//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdExecSpec
    {
        /// <summary>
        /// The path to the tool executable
        /// </summary>
        public readonly FS.FilePath ToolPath;

        /// <summary>
        /// The arguments to pass to the tool
        /// </summary>
        public readonly string Args;

        /// <summary>
        /// The working folder, if any
        /// </summary>
        public FS.FolderPath WorkingDir;

        /// <summary>
        /// Environment variables to use, if any
        /// </summary>
        public NamedValues<string> Vars;

        [MethodImpl(Inline)]
        public CmdExecSpec(FS.FilePath tool, string args, FS.FolderPath? root = null)
        {
            ToolPath = tool;
            Args = args;
            WorkingDir = root ?? FS.FolderPath.Empty;
            Vars = default;
        }
    }
}