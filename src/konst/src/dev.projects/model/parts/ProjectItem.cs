//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ProjectModel
    {
        public readonly struct ProjectItem : IProjectItem<ProjectItem>
        {
            readonly IProjectItem Definition;

            [MethodImpl(Inline)]
            public ProjectItem(IProjectItem src)
                => Definition = src;

            string IProjectElement.Name
                => Definition.Name;

            [MethodImpl(Inline)]
            string IProjectElement.Render()
                => Definition.Render();
        }
    }
}