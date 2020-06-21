//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum CharGroup : uint
    {
        None = 0,

        Digit = 1,

        Letter = 2,

    }
    
    public readonly struct DigitGroup
    {

    }

    public readonly struct LetterGroup
    {
        
    }

}