//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    using A = OpKindAttribute;
    using K = UnaryBitLogicKind;

    public sealed class NotAttribute : A { public NotAttribute() : base(K.Not) {} }
}