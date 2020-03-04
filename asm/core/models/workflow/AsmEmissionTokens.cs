//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public static class AsmEmissionTokens
    {
        [MethodImpl(Inline)]
        public static AsmEmissionTokens<AssemblyUri> From(AssemblyId src, AsmEmissionToken[] tokens)
            => From(AssemblyUri.Define(src),tokens);

        [MethodImpl(Inline)]
        public static AsmEmissionTokens<ApiHostUri> From(ApiHostUri src, AsmEmissionToken[] tokens)
            => From<ApiHostUri>(src, tokens);

        [MethodImpl(Inline)]
        public static AsmEmissionTokens<OpUri> From(OpUri groupUri, IEnumerable<AsmEmissionToken> tokens)
            => From(groupUri, tokens.ToArray());

        /// <summary>
        /// Defines a group of related emissions
        /// </summary>
        /// <param name="uri">The group uri</param>
        /// <param name="tokens">The group members</param>
        [MethodImpl(Inline)]
        static AsmEmissionTokens<S> From<S>(S src, AsmEmissionToken[] tokens)
            where S : IUri
                => new AsmEmissionTokens<S>(src, tokens);
    }

    /// <summary>
    /// Defines a grouping construct that serves as evidence for emission of related functions
    /// </summary>
    public readonly struct AsmEmissionTokens<S> : IAnyFiniteSeq<AsmEmissionToken>
        where S : IUri
    {
        /// <summary>
        /// Token origin
        /// </summary>
        public readonly S Source;
        
        /// <summary>
        /// The group members
        /// </summary>
        public AsmEmissionToken[] Content {get;}

        [MethodImpl(Inline)]
        internal AsmEmissionTokens(S source, AsmEmissionToken[] tokens)
        {
            this.Content = tokens;
            this.Source = source;
        }
    }   
}