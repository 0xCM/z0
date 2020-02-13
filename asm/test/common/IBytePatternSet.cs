//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    
    using static zfunc;

    public interface IBytePatternSet
    {
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