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

        public FS.FolderPath ScriptDir
            => Paths.ToolScriptDir(Id);

        public FS.Files Inputs()
            => Paths.ToolInDir(Id).AllFiles;

        public FS.Files Outputs()
            => Paths.ToolOutDir(Id).AllFiles;

        public FS.FilePath Script(FS.FileName name)
            => ScriptDir + name;

        public FS.FilePath Input(FS.FileName name)
            => InDir + name;

        public FS.FilePath Output(FS.FileName name)
            => OutDir + name;

        public virtual FS.FilePath ToolPath()
            => FS.path(string.Format("{0}.{1}", Id.Format(), FS.Exe));
    }
}