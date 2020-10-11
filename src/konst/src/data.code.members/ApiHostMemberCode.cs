//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Joins host-defined members with executable code
    /// </summary>
    public readonly struct ApiHostMemberCode
    {
        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The code-correlated members
        /// </summary>
        public ApiCodeIndex Members {get;}

        [MethodImpl(Inline)]
        public ApiHostMemberCode(ApiHostUri host, ApiCodeIndex members)
        {
            Host = host;
            Members = members;
        }
    }
}