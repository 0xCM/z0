//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
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

    public static class ByteParserStateOps
    {
        public static bool Finished(this ByteParserState state)
            => (state & ByteParserState.Completed) != 0;

        public static bool IsAccepting(this ByteParserState state)
            => state == ByteParserState.Accepting;

        public static bool IsSome(this ByteParserState state)
            => state != 0;

        public static bool Success(this ByteParserState state)
            => state == ByteParserState.Succeeded;
    }    
}