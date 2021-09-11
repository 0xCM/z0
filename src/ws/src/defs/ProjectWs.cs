//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public sealed class ProjectWs : IProjectWs, IWorkspace<ProjectWs>
    {
        [MethodImpl(Inline)]
        public static ProjectWs create(FS.FolderPath home)
            => new ProjectWs(home);

        public FS.FolderPath Root {get;}

        public Identifier Name
        {
            [MethodImpl(Inline)]
            get => "projects";
        }

        Dictionary<ProjectId,ProjectConfig> ConfigLookup;

        public ProjectWs(FS.FolderPath src)
        {
            Root = src;
            ConfigLookup = dict<ProjectId,ProjectConfig>();
        }

        public bool Settings(ProjectId id, out ProjectConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ProjectId id, in ProjectConfig src)
            => ConfigLookup[id] = src;
    }
}