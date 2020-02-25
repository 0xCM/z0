//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
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

   public interface IBytePatternSet<P,O> : IBytePatternSet<P>
        where P : unmanaged, Enum
        where O : unmanaged, Enum
    {
        new O MatchOffset(P kind);     

        [MethodImpl(Inline)]
        int IBytePatternSet<P>.MatchOffset(P kind)
            => evalue<O,int>(MatchOffset(kind));
    }

}