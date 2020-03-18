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

    using A = OpSubjectAttribute;

    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public abstract class OpSubjectAttribute : OpAttribute
    {
        protected OpSubjectAttribute(object id) 
            : base(false) 
        {

            KindId = (OpKindId)id;
        }

        public OpKindId KindId {get;}
    }

    public interface IOpKind<T>
        where T : unmanaged, IOpKind<T>
    {   
        OpKindId Id {get;}    
    }

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute() : base(Identity) {} }
}