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
        static ApiClass @class(object id)
            => (ApiClass)(ulong)Convert.ChangeType(id, typeof(ulong));

        protected OpKindAttribute(object id, ApiAsmClass asm = 0)
            : base(@class(id))
        {

        }

        public OpKindAttribute()
        {

        }
    }
}