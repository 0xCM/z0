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
        public readonly struct EmbeddedResource : IProjectItem<EmbeddedResource>
        {
            public const string TagName = nameof(EmbeddedResource);

            const string DefaultFormat = OpenTagFence + TagName + Delimiter + nameof(Include) + AttribSetOpen + Arg0 + AttribSetClose;

            public readonly string Include;

            [MethodImpl(Inline)]
            public EmbeddedResource(string include)
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