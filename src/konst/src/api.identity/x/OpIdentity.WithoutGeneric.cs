//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    partial class XApiIdentity
    {
       /// <summary>
        /// Disables the generic indicator
        /// </summary>
        public static OpIdentity WithoutGeneric(this OpIdentity src)
        {
            var parts = ApiIdentity.components(src).ToArray();
            if(parts.Length < 2)
                return src;

            if(parts[1].Identifier[0] != IDI.Generic)
                return src;

            parts[1] = parts[1].WithText(parts[1].Identifier.Substring(1));
            return ApiIdentity.build(parts);
        }
    }
}