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
        public static IProjectWs create(FS.FolderPath home, ProjectId id)
            => new ProjectWs(home,id);

        public override WsKind Kind => WsKind.Project;

        public ProjectId Project {get;}

        public ProjectWs(FS.FolderPath src, ProjectId project)
            : base(src)
        {
            Project = project;
        }
    }
}