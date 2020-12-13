//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
       /// <summary>
        /// Retrieves a type's specialized identity provider, if it has one; otherwise, returns a caller-supplied fallback
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="fallback">The identity provider to yield if the type does not have a specialized provider</param>
        [MethodImpl(Inline), Op]
        public static ITypeIdentityProvider provider(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => TypeIdentities.provider(src,fallback);
    }
}