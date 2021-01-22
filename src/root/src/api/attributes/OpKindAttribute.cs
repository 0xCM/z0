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

        protected OpKindAttribute(object id, AsmClass asm = 0)
            : base(@class(id), asm)
        {

        }

        public OpKindAttribute()
        {

        }
    }
}