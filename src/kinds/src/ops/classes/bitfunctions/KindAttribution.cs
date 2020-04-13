//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = BitFunctionKind;    
    using A = OpKindAttribute;

    public sealed class TestCAttribute : A { public TestCAttribute(string group = null) : base(K.TestC, group) {} }
    
    public sealed class TestZAttribute : A { public TestZAttribute(string group = null) : base(K.TestZ, group) {} }

}