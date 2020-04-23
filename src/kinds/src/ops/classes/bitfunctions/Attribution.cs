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

    public sealed class MuxAttribute : A { public MuxAttribute(string group = null) : base(K.Mux, group) {} }

    public sealed class PopAttribute : A { public PopAttribute(string group = null) : base(K.Pop, group) {} }

    public sealed class NtzAttribute : A { public NtzAttribute(string group = null) : base(K.Ntz, group) {} }

    public sealed class NlzAttribute : A { public NlzAttribute(string group = null) : base(K.Nlz, group) {} }

    public sealed class ScatterAttribute : A { public ScatterAttribute(string group = null) : base(K.Scatter, group) {} }

    public sealed class GatherAttribute : A { public GatherAttribute(string group = null) : base(K.Gather, group) {} }

    public sealed class MixAttribute : A { public MixAttribute(string group = null) : base(K.Mix, group) {} }    

   public sealed class RankAttribute : A { public RankAttribute(string group = null) : base(K.Rank, group) {} }    
}