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
        public readonly struct ProjectProperty : IProjectProperty<ProjectProperty>
        {
            readonly IProjectProperty Definition;

            [MethodImpl(Inline)]
            public ProjectProperty(IProjectProperty src)
                => Definition = src;

            string IProjectElement.Name
                => Definition.Name;

            string IProjectElement.Render()
                => Definition.Render();

            string IProjectProperty.Value
                => Definition.Value;
        }
    }
}