//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public abstract class OpKindAttribute : OpAttribute
    {
        protected OpKindAttribute(object id, object group = null)
            : base(group?.ToString() ?? string.Empty)
        {
            KindId = ApiAttributes.OpKindId(id);
        }

        public ApiKeyId KindId {get;}
    }
}