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

    public sealed class ProjectWs : Workspace<ProjectWs>, IProjectWs
    {
        [MethodImpl(Inline)]
        public static ProjectWs create(FS.FolderPath home)
            => new ProjectWs(home);

        public override WsKind Kind => WsKind.Projects;

        Dictionary<ProjectId,ProjectConfig> ConfigLookup;

        public ProjectWs(FS.FolderPath src)
            : base(src)
        {
            ConfigLookup = dict<ProjectId,ProjectConfig>();
        }

        public bool Settings(ProjectId id, out ProjectConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ProjectId id, in ProjectConfig src)
            => ConfigLookup[id] = src;
    }
}