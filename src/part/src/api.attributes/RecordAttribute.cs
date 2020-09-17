//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a structural type that be serialized as a record, of some sort
    /// </summary>
    public class TableAttribute : Attribute
    {
        public TableAttribute()
        {
            Name = "";
        }

        public TableAttribute(string name)
        {
            Name = name;
        }

        public string Name {get;}
    }

    public class TableFieldAttribute : Attribute
    {
        public TableFieldAttribute()
        {
            Descriptions = Array.Empty<string>();
        }

        public TableFieldAttribute(params string[] descriptions)
        {
            Descriptions = descriptions;
        }

        public string[] Descriptions {get;}
    }

}