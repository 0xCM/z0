//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    public enum EvalAspectKey : uint
    {
        Sequence = 0 | (10u << WidthOffset),

        CaseName =  1 | (70u << WidthOffset),

        Status =  2 | (10 << WidthOffset),

        Duration = 3  | (14u << WidthOffset),

        Timestamp =  4 | (26u << WidthOffset),

        Message = 5 | (20u << WidthOffset)
    }
}