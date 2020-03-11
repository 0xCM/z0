//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IBytePatternSet
    {
        /// <summary>
        /// The number of non-partial patterns in the set
        /// </summary>
        int FullPatternCount {get;}

        int PartialPatternCount {get;}
    }

   public interface IBytePatternSet<P> : IBytePatternSet
        where P : unmanaged, Enum
    {
        ReadOnlySpan<P> FullPatternKinds {get;}

        ReadOnlySpan<byte> FullPattern(P kind);   

        ReadOnlySpan<P> PartialPatternKinds {get;}

        ReadOnlySpan<byte?> PartialPattern(P kind);   

        bool IsSuccessPattern(P kind);

        int MatchOffset(P kind);     
    }
}