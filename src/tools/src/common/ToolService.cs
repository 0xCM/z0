//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{

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

        public FS.FilePath Script(FS.FolderPath dir, FS.FileName name)
            => dir + name;

        public FS.FilePath Input(FS.FileName name)
            => InDir + name;

        public FS.FilePath Output(FS.FileName name)
            => OutDir + name;

        public virtual FS.FilePath ToolPath()
            => FS.path(string.Format("{0}.{1}", Id.Format(), FS.Exe));

        protected static string format(FS.FilePath src)
            => src.Format(PathSeparator.BS);

        protected static FS.FilePath input(FS.FolderPath dir, FS.FileName name)
            => dir + name;

        protected static FS.FilePath output(FS.FolderPath dir, FS.FileName name)
            => dir + name;

        protected static FS.FileName file(Identifier src, FS.FileExt ext)
            => FS.file(src.Format(), ext);

        protected static FS.FileName binfile(Identifier src)
            => file(src, FS.Bin);

        protected static FS.FileName logfile(Identifier src)
            => file(src, FS.Log);
    }
}