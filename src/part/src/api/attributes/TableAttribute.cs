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
        public string TableId {get;}

        public byte FieldCount {get;}

        public TableAttribute(string name, byte fields)
        {
            TableId = name;
            FieldCount = fields;
        }
    }
}