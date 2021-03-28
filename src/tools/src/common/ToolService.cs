//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    public abstract class ToolService<T> : WfService<T>, ITool<T>
        where T : ToolService<T>, new()
    {
        public ToolId Id {get; protected set;}

        protected IEnvPaths Paths => Db;

        public FS.FolderPath InDir
            => Paths.ToolInDir(Id);

        public FS.FolderPath OutDir
            => Paths.ToolOutDir(Id);

        public FS.Files Inputs()
            => Paths.ToolInDir(Id).AllFiles;

        public FS.Files Outputs()
            => Paths.ToolOutDir(Id).AllFiles;
    }
}