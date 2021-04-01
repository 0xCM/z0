//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Loader;
    using System.Reflection;
    using System.Linq;

    using static Tooling.DotNet;

    public class PartContext : AssemblyLoadContext, IDisposable
    {
        IEnvPaths Paths;

        public FS.FolderPath LibDir {get;}

        public FS.FilePath LibPath {get;}

        public Assembly Component {get;}

        public Index<Assembly> Dependencies {get;}

        public PartContext(FS.FilePath src)
            : base(src.FileName.WithoutExtension.Format(), true)
        {
            Paths = EnvPaths.create();
            LibPath = src;
            LibDir = src.FolderPath;
            Component = LoadFromAssemblyPath(LibPath.Name);
            Dependencies = this.LoadPartDependencies(Component, LibDir).Distinct().Array();
        }

        public PartContext(PartId src)
            : base(src.Format(), true)
        {
            Paths = EnvPaths.create();
            LibDir = Paths.LibDir(src, TargetFrameworks.NetCoreApp31);
            LibPath = Paths.LibPath(src, TargetFrameworks.NetCoreApp31);
            Component = LoadFromAssemblyPath(LibPath.Name);
            Dependencies = this.LoadPartDependencies(Component, LibDir).Distinct().Array();
        }


        public void Dispose()
        {
            Unload();
        }
    }
}