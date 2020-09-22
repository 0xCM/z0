//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentity
    {
        /// <summary>
        /// Defines a type ideentity, bypassing validity checks
        /// </summary>
        /// <param name="src">The identity content</param>
        [MethodImpl(Inline), Op]
        internal static TypeIdentity type(string src)
            => new TypeIdentity(src);
    }
}