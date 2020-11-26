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

    public readonly struct ParseFunctions
    {
        public static ParseFunction<S,T> parser<S,T>()
        {
            if(typeof(S) == typeof(SlnFile))
                return @as<ParseFunction<SlnFile,Solution>,ParseFunction<S,T>>(parse);
            else
                throw no<S>();
        }

        public static ParseResult2<SlnFile> parse(in SlnFile src, out Solution dst)
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
                var configs = srcProject.ProjectConfigurations.Array();
                var kConfig = configs.Length;
            }

            return src;
        }
    }
}