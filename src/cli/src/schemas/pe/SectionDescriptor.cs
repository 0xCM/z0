//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SectionDescriptor
    {
        public Name Name {get;}

        public ImageSectionKind Kind {get;}

        [MethodImpl(Inline)]
        public SectionDescriptor(Name name, ImageSectionKind kind)
        {
            Name = name;
            Kind = kind;
        }
    }
}