//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    public class CodeTemplate
    {
        protected const string level0 = "";
        
        protected const string level1 = "    ";
        
        protected const string level2 = level1 + level1;
        
        protected const string level3 = level2 + level1;
        
        protected const string level4 = level3 + level1;
        
        protected string endl = text.eol();

        protected const char rbrace = Chars.RBrace;

        protected const char lbrace = Chars.LBrace;

        protected const string inline = "[MethodImpl(Inline)]";
        
        protected const string implicit_op ="public static implicit operator ";
    }
}