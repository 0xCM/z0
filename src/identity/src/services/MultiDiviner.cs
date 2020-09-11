//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct MultiDiviner : IMultiDiviner
    {
        public static IMultiDiviner Service => default(MultiDiviner);

        [MethodImpl(Inline)]
        public TypeIdentity DivineIdentity(Type src)
            => Identity.identify(src);

        [MethodImpl(Inline)]
        public OpIdentity DivineIdentity(MethodInfo src)
            => Identity.identify(src);

        public OpIdentity DivineIdentity(Delegate src)
            => Identity.identify(src);

        [MethodImpl(Inline)]
        public GenericOpIdentity GenericIdentity(MethodInfo src)
            => Identity.GenericIdentity(src);
    }
}