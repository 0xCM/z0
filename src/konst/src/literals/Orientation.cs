//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines orientation - a choice between exactly one of two values, e.g. top/bottom, front/back, 
    /// left/right, true/false. The labels chosen - "Left" and "Right" reflect convention, not semantics
    /// </summary>
    /// <remarks> This is one of the most elementary examples of duality, where entities (of some sort) 
    /// are partitioned into an equivalence class with exactly two members</remarks>
    public enum Orientation : sbyte
    {        
        /// <summary>
        /// Specifies a leftward orientation
        /// </summary>
        Left = - 1,
        
        /// <summary>
        /// Specifies a rightward orientation
        /// </summary>
        Right = 1
    }
}