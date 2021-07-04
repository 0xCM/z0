//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class SymClassAttribute : Attribute
    {
        public SymClassAttribute(Type src)
        {
            Classified = src;
        }

        public Type Classified {get;}
    }
}