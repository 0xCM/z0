//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = SystemApiClass;
    using A = OpKindAttribute;


    public class InitAttribute : A { public InitAttribute() : base(K.Init) {} }

    public class ClassifyAttribute : A { public ClassifyAttribute() : base(K.Kind) {} }
}