//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a grouping construct that serves as evidence for emission of related functions
    /// </summary>
    public readonly struct AsmEmissionGroup
    {
        /// <summary>
        /// Defines a group of related emissions
        /// </summary>
        /// <param name="uri">The group uri</param>
        /// <param name="tokens">The group members</param>
        [MethodImpl(Inline)]
        public static AsmEmissionGroup Define(OpUri uri, AsmEmissionToken[] tokens)
            => new AsmEmissionGroup(uri, tokens);

        [MethodImpl(Inline)]
        AsmEmissionGroup(OpUri groupUri, AsmEmissionToken[] tokens)
        {
            this.Tokens = tokens;
            this.Uri = groupUri;
        }

        /// <summary>
        /// The group uri
        /// </summary>
        public readonly OpUri Uri;
        
        /// <summary>
        /// The group members
        /// </summary>
        public readonly AsmEmissionToken[] Tokens;                
    }
    
}