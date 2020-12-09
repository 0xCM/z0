//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ProjectModel
    {
        public readonly struct ProjectProperty<T> : IProjectProperty<ProjectProperty<T>>
            where T : IProjectProperty
        {
            readonly T Definition;

            public string Name
            {
                [MethodImpl(Inline)]
                get => Definition.Name;
            }

            public string Value
            {
                [MethodImpl(Inline)]
                get => Definition.Value;
            }

            [MethodImpl(Inline)]
            public static implicit operator ProjectProperty(ProjectProperty<T> src)
                => new ProjectProperty(src);

            [MethodImpl(Inline)]
            public static implicit operator ProjectProperty<T>(T src)
                => new ProjectProperty<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator T(ProjectProperty<T> src)
                => src.Definition;

            [MethodImpl(Inline)]
            public ProjectProperty(T value)
                => Definition = value;

            string IProjectElement.Name
                => Name;

            string IProjectProperty.Value
                => Definition.Value;
        }
    }
}