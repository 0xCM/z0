//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public class ParserAttribute : Attribute
    {
        public ParserAttribute()
        {
            
        }

        public ParserAttribute(Type parser)
        {
            this.ParserType = parser;
        }

        public Type ParserType {get;}

    }
}