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

    partial struct ApiIdentity
    {
        /// <summary>
        /// Identifies a generic method
        /// </summary>
        /// <param name="src">The method to identify</param>
        [MethodImpl(Inline), Op]
        public static ApiGenericOpIdentity generic(MethodInfo src)
            => new ApiGenericOpIdentity(identify(src));

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static ApiGenericOpIdentity generic(string src)
            => new ApiGenericOpIdentity(src);
    }
}