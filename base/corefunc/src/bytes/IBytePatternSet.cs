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
        /// The number of patterns in the set
        /// </summary>
        int PatternCount {get;}
    }

   public interface IBytePatternSet<P> : IBytePatternSet
        where P : unmanaged, Enum
    {
        ReadOnlySpan<P> PatternKinds {get;}

        ReadOnlySpan<byte> Pattern(P kind);   
        
        int PatternValue(P kind);     
    }

   public interface IBytePatternSet<P,C> : IBytePatternSet<P>
        where P : unmanaged, Enum
        where C : unmanaged, Enum
    {
        new C PatternValue(P kind);     

        int IBytePatternSet<P>.PatternValue(P kind)
            => evalue<C,int>(PatternValue(kind));
    }

}