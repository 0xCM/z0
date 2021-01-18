//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XApi
    {
        /// <summary>
        /// Determines whether a type is classified as a blocked type via attribution
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsBlocked(this Type t)
            => t.Tagged<BlockedAttribute>();
    }
}