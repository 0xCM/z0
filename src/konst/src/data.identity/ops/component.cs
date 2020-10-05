//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiIdentify
    {
        [Op]
        public static Option<ApiIdentityPart> component(OpIdentity src, int index)
        {
            var parts = components(src).ToArray();
            if(index <= parts.Length - 1)
                return parts[index];
            else
                return none<ApiIdentityPart>();
        }
    }
}