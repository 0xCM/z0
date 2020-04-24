//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = BitFunctionKind;    
    using A = OpKindAttribute;

    public sealed class TestCAttribute : A { public TestCAttribute(object group = null) : base(K.TestC, group) {} }
    
    public sealed class TestZAttribute : A { public TestZAttribute(object group = null) : base(K.TestZ, group) {} }

    public sealed class MuxAttribute : A { public MuxAttribute(object group = null) : base(K.Mux, group) {} }

    public sealed class PopAttribute : A { public PopAttribute(object group = null) : base(K.Pop, group) {} }

    public sealed class NtzAttribute : A { public NtzAttribute(object group = null) : base(K.Ntz, group) {} }

    public sealed class NlzAttribute : A { public NlzAttribute(object group = null) : base(K.Nlz, group) {} }

    public sealed class ScatterAttribute : A { public ScatterAttribute(object group = null) : base(K.Scatter, group) {} }

    public sealed class GatherAttribute : A { public GatherAttribute(object group = null) : base(K.Gather, group) {} }

    public sealed class MixAttribute : A { public MixAttribute(object group = null) : base(K.Mix, group) {} }    

   public sealed class RankAttribute : A { public RankAttribute(object group = null) : base(K.Rank, group) {} }    
}