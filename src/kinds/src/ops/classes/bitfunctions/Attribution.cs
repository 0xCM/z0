//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = BitFunctionKind;    
    using A = OpKindAttribute;

    public sealed class TestCAttribute : A { public TestCAttribute() : base(K.TestC) {} }
    
    public sealed class TestZAttribute : A { public TestZAttribute() : base(K.TestZ) {} }

    public sealed class MuxAttribute : A { public MuxAttribute() : base(K.Mux) {} }

    public sealed class PopAttribute : A { public PopAttribute() : base(K.Pop) {} }

    public sealed class NtzAttribute : A { public NtzAttribute() : base(K.Ntz) {} }

    public sealed class NlzAttribute : A { public NlzAttribute() : base(K.Nlz) {} }

    public sealed class ScatterAttribute : A { public ScatterAttribute() : base(K.Scatter) {} }

    public sealed class GatherAttribute : A { public GatherAttribute() : base(K.Gather) {} }

    public sealed class MixAttribute : A { public MixAttribute() : base(K.Mix) {} }    

    public sealed class RankAttribute : A { public RankAttribute() : base(K.Rank) {} }    

    public sealed class BitSegAttribute : A { public BitSegAttribute() : base(K.BitSeg) {} }    

    public sealed class TestBitAttribute : A { public TestBitAttribute() : base(K.TestBit) {} }    

    public sealed class SetBitAttribute : A { public SetBitAttribute() : base(K.SetBit) {} }    

    public sealed class TestBitsAttribute : A { public TestBitsAttribute() : base(K.TestBits) {} }    

    public sealed class StitchAttribute : A { public StitchAttribute() : base(K.Stitch) {} }    

    public sealed class BitCopyAttribute : A { public BitCopyAttribute() : base(K.BitCopy) {} }    

    public sealed class BitCellAttribute : A { public BitCellAttribute() : base(K.BitCell) {} }    

    public sealed class LoPosAttribute : A { public LoPosAttribute() : base(K.LoPos) {} }      
    
    public sealed class HiPosAttribute : A { public HiPosAttribute() : base(K.HiPos) {} }      

    public sealed class HiSegAttribute : A { public HiSegAttribute() : base(K.HiSeg) {} }    

    public sealed class LoSegAttribute : A { public LoSegAttribute() : base(K.LoSeg) {} }    

    public sealed class ZHiAttribute : A { public ZHiAttribute() : base(K.ZHi) {} } 

    public sealed class PackAttribute : A { public PackAttribute() : base(K.Pack) {} } 

    public sealed class UnpackAttribute : A { public UnpackAttribute() : base(K.Unpack) {} } 

    public sealed class HProdAttribute : A { public HProdAttribute() : base(K.HProd) {} } 


    
}