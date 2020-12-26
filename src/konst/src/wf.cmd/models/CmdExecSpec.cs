//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public struct CmdExecSpec
    {
        /// <summary>
        /// The path to the tool executable
        /// </summary>
        public FS.FilePath CmdPath;

        /// <summary>
        /// The arguments to pass to the tool
        /// </summary>
        public string Args;

        /// <summary>
        /// The working folder, if any
        /// </summary>
        public FS.FolderPath WorkingDir;

        /// <summary>
        /// Environment variables to use, if any
        /// </summary>
        public NamedValues<string> Vars;
    }
}