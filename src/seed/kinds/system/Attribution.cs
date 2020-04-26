//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = SystemOpKind;
    using A = OpKindAttribute;

    public class LoadAttribute : A { public LoadAttribute() : base(K.Load) {} }

    public class StoreAttribute : A { public StoreAttribute() : base(K.Store) {} }

    public class AllocAttribute : A { public AllocAttribute() : base(K.Alloc) {} }

    public class InitAttribute : A { public InitAttribute() : base(K.Init) {} }

    public class ClassifyAttribute : A { public ClassifyAttribute() : base(K.Kind) {} }


}