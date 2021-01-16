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
        /// Produces the canonical name of a kinded operation
        /// </summary>
        /// <param name="src">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string name(ApiClass src)
            => src.Format();

        /// <summary>
        /// Produces the canonical name of a kinded vectorized operation
        /// </summary>
        /// <param name="src">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string vname(ApiClass src)
            => $"v{src.Format()}";
    }
}