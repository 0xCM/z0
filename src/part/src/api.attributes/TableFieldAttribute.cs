//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class TableFieldAttribute : Attribute
    {
        public object Kind {get;}

        public TableFieldAttribute()
        {
            Kind = 0ul;
        }

        public TableFieldAttribute(object kind)
        {
            Kind = kind ?? 0ul;
        }
    }
}