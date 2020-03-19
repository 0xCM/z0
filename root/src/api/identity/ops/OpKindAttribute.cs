//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static OpKindId;

    using A = OpKindAttribute;

    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public abstract class OpKindAttribute : OpAttribute
    {
        protected OpKindAttribute(object id) 
            : base(false) 
        {

            KindId = (OpKindId)id;
        }

        public OpKindId KindId {get;}
    }

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute() : base(Identity) {} }
}