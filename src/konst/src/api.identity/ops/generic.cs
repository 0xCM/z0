//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static OpIdentityG generic(string src)
            => new OpIdentityG(src);
    }
}