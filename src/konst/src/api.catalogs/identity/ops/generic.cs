//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Identifies a generic method
        /// </summary>
        /// <param name="src">The method to identify</param>
        [MethodImpl(Inline), Op]
        public static OpIdentityG generic(MethodInfo src)
            => new OpIdentityG(artifact(src));

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static OpIdentityG generic(string src)
            => new OpIdentityG(src);
    }
}