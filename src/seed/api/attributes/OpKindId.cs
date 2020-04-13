//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public abstract class OpKindAttribute : OpAttribute
    {
        protected OpKindAttribute(object id, string group = null) 
        {
            KindId = (OpKindId)(ulong)Convert.ChangeType(id,typeof(ulong));
            Group = group ?? string.Empty;
        }

        public string Group {get;}

        public OpKindId KindId {get;}
    }
}