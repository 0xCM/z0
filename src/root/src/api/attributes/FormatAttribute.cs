//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class FormatAttribute : Attribute
    {
        public FormatAttribute(string pattern)
        {
            Pattern = pattern;
        }

        public string Pattern {get;}
    }
}