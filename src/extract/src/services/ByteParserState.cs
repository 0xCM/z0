//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Defines the potential byte parser states
    /// </summary>
    public enum ByteParserState
    {
        None = 0,
        
        Accepting = 1,
        
        Failed = 2,
        
        Succeeded = 4, 

        Unmatched = 8,

        Completed = Failed | Succeeded
    }


}