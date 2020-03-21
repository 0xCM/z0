//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static UnaryBitLogicKind;

    using A = OpKindAttribute;

    public sealed class NotAttribute : A { public NotAttribute() : base(Not) {} }

}