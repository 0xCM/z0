//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using static TernaryBitLogicKind;
    using A = OpKindAttribute;

   public sealed class SelectAttribute : A { public SelectAttribute() : base(OpKindId.Select) {} } 

}