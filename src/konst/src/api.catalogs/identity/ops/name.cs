//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Produces the canonical name of a kinded operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string name(ApiClass k)
            => k.Format();

        /// <summary>
        /// Produces the canonical name of a kinded vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        [MethodImpl(Inline)]
        public static string vname(ApiClass k)
            => k.Format(true);
    }
}