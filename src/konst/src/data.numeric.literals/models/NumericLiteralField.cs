//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    public enum NumericLiteralField : uint
    {
        Name = 0 | (30 << WidthOffset),

        Base = 1 | (10 << WidthOffset),

        Data = 2  | (80 << WidthOffset),

        Text = 3 | (80 << WidthOffset),
    }         
}