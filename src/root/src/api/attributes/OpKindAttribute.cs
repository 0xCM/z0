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
    public class OpKindAttribute : OpAttribute
    {
        public static ApiClass OpKindId(object id)
            => (ApiClass)(ulong)Convert.ChangeType(id, typeof(ulong));

        protected OpKindAttribute(object id, object group = null)
            : base(group?.ToString() ?? string.Empty)
        {
            Id = OpKindId(id);
        }

        public OpKindAttribute()
            : base("")
        {

        }

        public ApiClass Id {get;}
    }
}