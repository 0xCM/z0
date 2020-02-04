//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static zfunc;

    using static TypeIdentity;

    public static class TypeIdentityX
    {
        /// <summary>
        /// Defines a source type identifier, intended to be unique within a caller-determined scope
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        public static TypeIdentity Identity(this Type t)
            => TypeIdentities.identify(t);
    }

}