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

    public class PartContext : AssemblyLoadContext, IDisposable
    {
        IEnvPaths Paths;

        public FS.FolderPath LibDir {get;}

        public FS.FilePath LibPath {get;}

        public Assembly Component {get;}

        public Index<Assembly> Dependencies {get;}

        public PartContext(FS.FilePath src, bool collectible = true)
            : base(collectible)
        {
            Paths = EnvPaths.create();
            LibPath = src;
            LibDir = src.FolderPath;
            Component = LoadFromAssemblyPath(src.Name);
            Dependencies = this.LoadPartDependencies(Component, LibDir).Distinct().Array();
        }

        public PartContext(PartId src, bool collectible = true)
            : base(src.Format(), collectible)
        {
            Paths = EnvPaths.create();
            LibDir = Paths.LibDir(src, NetCoreApp31);
            LibPath = Paths.LibPath(src, NetCoreApp31);
            Component = LoadFromAssemblyPath(LibPath.Name);
            Dependencies = this.LoadPartDependencies(Component, LibDir).Distinct().Array();
        }


        public void Dispose()
        {
            Unload();
        }

        const string NetCoreApp31 = "netcoreapp3.1";
    }
}