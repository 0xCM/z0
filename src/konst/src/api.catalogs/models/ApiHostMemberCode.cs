//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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
        public ApiMemberCodeIndex Members {get;}

        [MethodImpl(Inline)]
        public ApiHostMemberCode(ApiHostUri host, ApiMemberCodeIndex members)
        {
            Host = host;
            Members = members;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host.IsEmpty || Members.IsEmpty;
        }

        public static ApiHostMemberCode Empty
        {
            [MethodImpl(Inline)]
            get => new ApiHostMemberCode(ApiHostUri.Empty, ApiMemberCodeIndex.Empty);
        }
    }
}