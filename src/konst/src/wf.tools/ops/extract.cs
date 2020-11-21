//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Tooling
    {
        [Projector]
        static ref CmdOption extract(MemberInfo src, out CmdOption dst)
        {
            var tag = src.RequiredTag<SlotAttribute>();
            var purpose = src.Tag<MeaningAttribute>().MapValueOrElse(t => (string)t.Content, () => EmptyString);
            dst = option(text.ifempty(tag.Name, src.Name), purpose);
            return ref dst;
        }
    }
}