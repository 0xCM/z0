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
    /// Defines a grouping construct for emission of related functions
    /// </summary>
    public readonly struct AsmEmissionGroup
    {
        /// <summary>
        /// Defines a group of related emissions
        /// </summary>
        /// <param name="groupid">The group identifier</param>
        /// <param name="tokens">The group members</param>
        [MethodImpl(Inline)]
        public static AsmEmissionGroup Define(OpIdentity groupid, AsmEmissionToken[] tokens)
            => new AsmEmissionGroup(groupid, tokens);
            
        [MethodImpl(Inline)]
        AsmEmissionGroup(OpIdentity groupid, AsmEmissionToken[] tokens)
        {
            this.Tokens = tokens;
            this.Id = groupid;
        }

        /// <summary>
        /// The group identity
        /// </summary>
        public readonly OpIdentity Id;
        
        /// <summary>
        /// The group members
        /// </summary>
        public readonly AsmEmissionToken[] Tokens;                
    }
    
}