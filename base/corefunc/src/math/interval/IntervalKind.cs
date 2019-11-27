//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines interval classifications predicated on endpoint containment
    /// </summary>
    public enum IntervalKind : uint
    {
        Closed = 0,
        
        Open = 1,
        
        LeftClosed = 4,        
        
        RightClosed = 8,
        
        LeftOpen = RightClosed,
        
        RightOpen = LeftClosed
    }
}