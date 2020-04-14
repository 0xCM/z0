//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Seed;
    
    partial class Identity
    {

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = Identify.parts(src).ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return Option.none<IdentityPart>();
        }
    }
}