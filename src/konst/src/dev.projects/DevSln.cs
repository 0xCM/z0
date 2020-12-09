//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.Build.Construction;

    using MsBC = Microsoft.Build.Construction;

    using static Konst;
    using static z;

    public readonly struct DevSln
    {
        public static ref Solution parse(in SlnFile src, out Solution dst)
        {
            dst = new Solution();
            var data = MsBC.SolutionFile.Parse(src.Name);
            var projects = data.ProjectsInOrder;
            var count = projects.Count;
            var buffer = alloc<SlnProject>(count);
            dst.Path = src;
            dst.Projects = buffer;

            ref var dstProject = ref first(span(buffer));
            for(var i=0; i<count; i++)
            {
                var srcProject = projects[i];
                dstProject = ref seek(dstProject,i);
                dstProject.Path = FS.path(srcProject.AbsolutePath);
                dstProject.ProjectName = srcProject.ProjectName;
                dstProject.ProjectGuid = Guid.Parse(srcProject.ProjectGuid);
                dstProject.Dependencies = srcProject.Dependencies.Map(x => Guid.Parse(x));
                var configs = @readonly(srcProject.ProjectConfigurations.Values.Array());
                var kConfig = configs.Length;
                dstProject.Configurations = sys.alloc<SlnProjectConfig>(kConfig);
                var dstConfigs = dstProject.Configurations.Edit;
                for(var j=0; j<kConfig; j++)
                    project(skip(configs,i), ref seek(dstConfigs, j));

            }

            return ref dst;
        }


        public static ref SlnProjectConfig project(in ProjectConfigurationInSolution src, ref SlnProjectConfig dst)
        {
            dst.Build = src.IncludeInBuild;
            dst.FullName = src.FullName;
            dst.SimpleName = src.ConfigurationName;
            dst.Platform = src.PlatformName;
            return ref dst;
        }
    }
}