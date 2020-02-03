//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public static partial class FastOpX
    {
        public static OpIdentity Identity(this IMethodMetadata src)
            => src.Element.Identify();

        public static IEnumerable<M> Generic<M>(this IEnumerable<M> src)
            where M : IMethodMetadata
                => from m in src
                where m.Element.IsGenericMethod
                    select m;

        public static IEnumerable<M> NonGeneric<M>(this IEnumerable<M> src)
            where M : IMethodMetadata
                => from m in src
                where !m.Element.IsGenericMethod
                    select m;

        public static IEnumerable<M> WithName<M>(this IEnumerable<M> src, string Name)
            where M : IMethodMetadata
                => from m in src
                    where m.Element.Name == Name
                    select m;
    }
}