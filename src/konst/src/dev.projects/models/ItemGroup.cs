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
        public readonly struct ItemGroup
        {
            public const string TagName = nameof(ItemGroup);

            public readonly ProjectItem[] Data;

            [MethodImpl(Inline)]
            public ItemGroup(ProjectItem[] src)
                => Data = src;
        }
    }
}