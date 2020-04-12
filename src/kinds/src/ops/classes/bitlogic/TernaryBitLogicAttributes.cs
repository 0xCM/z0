//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using A = OpKindAttribute;

    public sealed class SelectAttribute : A { public SelectAttribute() : base(OpKindId.Select) {} } 
}