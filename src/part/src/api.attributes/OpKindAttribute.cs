//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public class OpKindAttribute : OpAttribute
    {
        protected OpKindAttribute(object id, object group = null)
            : base(group?.ToString() ?? string.Empty)
        {
            Id = ApiAttributes.OpKindId(id);
        }

        public OpKindAttribute()
            : base("")
        {

        }

        public ApiOpId Id {get;}
    }
}