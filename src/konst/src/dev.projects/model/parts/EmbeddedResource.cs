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
        public readonly struct EmbeddedResourceSpec : IProjectItem<EmbeddedResourceSpec>
        {
            public const string TagName = nameof(EmbeddedResourceSpec);

            const string DefaultFormat = OpenTagFence + TagName + Delimiter + nameof(Include) + AttribSetOpen + Arg0 + AttribSetClose;

            public readonly string Include;

            [MethodImpl(Inline)]
            public EmbeddedResourceSpec(string include)
            {
                Include = include;
            }

            [MethodImpl(Inline)]
            public string Render()
                => string.Format(DefaultFormat, Include);

            [MethodImpl(Inline)]
            public string Format()
                => Render();

            public override string ToString()
                => Render();

            string IProjectElement.Name
                => TagName;
        }
    }
}