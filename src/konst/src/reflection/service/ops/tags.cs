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

    partial struct ClrReflexSvc
    {
        public static TaggedMembers<MethodInfo,A> tags<A>(Type src)
            where A : Attribute
                => src.DeclaredMethods().Where(m => m.Tagged<A>()).Select(x => member(x, x.Tag<A>().Require()));
    }
}