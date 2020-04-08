//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = BitLevelOpKind;    
    using A = OpKindAttribute;

    public sealed class TestCAttribute : A { public TestCAttribute() : base(K.TestC) {} }
    
    public sealed class TestZAttribute : A { public TestZAttribute() : base(K.TestZ) {} }

}