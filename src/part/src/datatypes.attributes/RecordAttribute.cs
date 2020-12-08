//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Struct)]
    public class RecordAttribute : Attribute
    {
        public RecordAttribute()
        {

        }

        public RecordAttribute(string schema)
        {
            Schema = schema;
        }

        public RecordAttribute(string schema, string detail)
        {
            Schema = schema;
            Detail = detail;
        }

        public string Schema {get;}

        public string Detail {get;}
    }
}