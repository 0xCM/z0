//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class)]
    public class RecordSetAttribute : Attribute
    {
        public string Docs {get;}

        public RecordSetAttribute()
        {
            Docs = string.Empty;
        }

        public RecordSetAttribute(string docs)
        {
            Docs = string.Empty;
        }
    }

}