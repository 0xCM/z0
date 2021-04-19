//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class DataProcessorAttribute : Attribute
    {
        public DataProcessorAttribute(string id)
        {
            Identifier = id;
        }

        public string Identifier {get;}
    }
}