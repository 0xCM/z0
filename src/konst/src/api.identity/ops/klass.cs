//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiIdentity
    {
        const NumericKind Closure = UnsignedInts;

        public static OpIdentity klass<K,T>(K @class, T t = default)
            where K : unmanaged, IApiClass
            where T : unmanaged
                => build(@class.Format(), (TypeWidth)memory.width<T>(), Numeric.kind<T>(), true);
    }
}