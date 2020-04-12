//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = TernaryArithmeticKind;    
    using A = OpKindAttribute;


    public sealed class FmaAttribute : A { public FmaAttribute() : base(K.Fma) {} }

    public sealed class ModMulAttribute : A { public ModMulAttribute() : base(K.ModMul) {} }
}