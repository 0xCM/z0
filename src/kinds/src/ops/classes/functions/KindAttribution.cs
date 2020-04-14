//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;    
    using K = FunctionKind;


    public sealed class BroadcastAttribute : A { public BroadcastAttribute(string group = null) : base(K.Broadcast, group) {} }


}