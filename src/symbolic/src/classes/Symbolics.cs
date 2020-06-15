//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ASCI
    {
        
    }

    public readonly struct Letter
    {
        
    }

    public readonly struct Number
    {
        
    }
    
    public readonly struct Symbolics
    {
        public static ASCI ASCI => default;

        public static LowerCased LowerCase => LowerCased.Case;

        public static UpperCased UpperCase => UpperCased.Case;

        public static Letter Letter => default;
        
        public static Number Number => default;
    }  
}