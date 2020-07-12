//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines interval classifications predicated on endpoint containment
    /// </summary>
    public enum IntervalKind : byte
    {
        Closed = 0,
        
        Open = 1,
        
        LeftClosed = 4,        
        
        RightClosed = 8,
        
        LeftOpen = RightClosed,
        
        RightOpen = LeftClosed
    }
}