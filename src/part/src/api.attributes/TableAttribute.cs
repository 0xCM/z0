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
    [AttributeUsage(AttributeTargets.Struct)]
    public class TableAttribute : Attribute
    {
        public string Name {get;}

        public object Kind {get;}

        public TableAttribute()
        {
            Name = "";
            Kind = 0ul;
        }

        public TableAttribute(object kind)
        {
            Name = "";
            Kind = kind ?? 0ul;
        }

        public TableAttribute(string name, object kind = null)
        {
            Name = name;
            Kind = kind ?? 0ul;
        }
    }
}