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

   public interface IBytePatternSet<T> : IBytePatternSet
        where T : unmanaged, Enum
    {
        ReadOnlySpan<T> PatternKinds {get;}

        ReadOnlySpan<byte> Pattern(T kind);   
        
        int PatternDelta(T kind);     
    }
}