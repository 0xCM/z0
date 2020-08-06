//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;    

    public enum PeHeaderField : uint
    {
        FileName = 0 | (26 << WidthOffset),

        Section = 1 | (10 << WidthOffset),

        Address = 2 | (16 << WidthOffset),

        Size = 3 | (10 << WidthOffset),
        
        EntryPoint = 4 | (16 << WidthOffset),

        CodeBase = 5 | (16 << WidthOffset),

        Gpt = 6 | (16 << WidthOffset),

        GptSize = 7 | (8 << WidthOffset)
    }
}