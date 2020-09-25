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
    
    public readonly struct ProjectItem<T> : IProjectItem<ProjectItem<T>>
        where T : IProjectItem
    {
        readonly T Definition;

        public string Name                
        {
            [MethodImpl(Inline)]
            get => Definition.Name;
        }

        [MethodImpl(Inline)]
        public static implicit operator ProjectItem(ProjectItem<T> src)
            => new ProjectItem(src);

        [MethodImpl(Inline)]
        public static implicit operator ProjectItem<T>(T src)
            => new ProjectItem<T>(src);
        
        [MethodImpl(Inline)]
        public static implicit operator T(ProjectItem<T> src)
            => src.Definition;
        
        [MethodImpl(Inline)]
        public ProjectItem(T value)
            => Definition = value;

        string IProjectElement.Name
            => Name;
    }
}