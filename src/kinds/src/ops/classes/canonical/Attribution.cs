//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = CanonicalKind;
    using A = OpKindAttribute;    

    public sealed class IdentityFunctionAttribute : A { public IdentityFunctionAttribute() : base(K.Identity) {} }

    public sealed class ConcatAttribute : A { public ConcatAttribute() : base(K.Concat) {} }

    public sealed class ReverseAttribute : A { public ReverseAttribute() : base(K.Reverse) {} }    

    public sealed class ParseAttribute : A { public ParseAttribute() : base(K.Parse) {} }    

    public sealed class SliceAttribute : A { public SliceAttribute() : base(K.Slice) {} }    

    public sealed class EnableAttribute : A { public EnableAttribute() : base(K.Enable) {} }    

    public sealed class DisableAttribute : A { public DisableAttribute() : base(K.Disable) {} }

    public sealed class LoAttribute : A { public LoAttribute() : base(K.Lo) {} }

    public sealed class HiAttribute : A { public HiAttribute() : base(K.Hi) {} }

    public sealed class LeftAttribute : A { public LeftAttribute() : base(K.Left) {} }

    public sealed class RightAttribute : A { public RightAttribute() : base(K.Right) {} }

    public sealed class ReplicateAttribute : A { public ReplicateAttribute() : base(K.Replicate) {} }    

    public sealed class SplitAttribute : A { public SplitAttribute() : base(K.Split) {} }    

    public sealed class ToggleAttribute : A { public ToggleAttribute() : base(K.Toggle) {} }        
}