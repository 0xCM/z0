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
        static OpKindId ToKindKid(object id)
            => (OpKindId)(ulong)Convert.ChangeType(id, typeof(ulong));
        
        protected OpKindAttribute(object id, object group = null) 
        {
            KindId = ToKindKid(id);
            Group = group?.ToString() ?? string.Empty;
        }

        public OpKindId KindId {get;}

        public string Group {get;}

        public override string Name => KindId.ToString().ToLower();
    }
}