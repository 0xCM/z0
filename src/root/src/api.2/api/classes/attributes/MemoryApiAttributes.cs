//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = MemoryApiClass;
    using A = OpKindAttribute;

    public class LoadAttribute : A { public LoadAttribute() : base(K.Load) {} }

    public class StoreAttribute : A { public StoreAttribute() : base(K.Store) {} }

    public class AllocAttribute : A { public AllocAttribute() : base(K.Alloc) {} }

    public class RecoverAttribute : A { public RecoverAttribute() : base(K.Recover) {} }

    public class MemAddAttribute : A { public MemAddAttribute() : base(K.MemAdd) {} }

    public class MemSubAttribute : A { public MemSubAttribute() : base(K.MemSub) {} }
}