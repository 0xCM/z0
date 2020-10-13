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

    using api = DataLayouts;

    public readonly struct LayoutSectionInfo : ITextual
    {
        public LayoutIdentity Id {get;}

        public StringRef SectionName {get;}

        public StringRef Content {get;}

        [MethodImpl(Inline)]
        public LayoutSectionInfo(LayoutIdentity id, string name, string content)
        {
            Id = id;
            SectionName = name;
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}