//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiBitFunctionClass;
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

    public sealed class Segment : A { public Segment() : base(K.Extract) {} }

    public sealed class TestBitAttribute : A { public TestBitAttribute() : base(K.TestBit) {} }

    public sealed class SetBitAttribute : A { public SetBitAttribute() : base(K.SetBit) {} }

    public sealed class TestBitsAttribute : A { public TestBitsAttribute() : base(K.TestBits) {} }

    public sealed class StitchAttribute : A { public StitchAttribute() : base(K.Stitch) {} }

    public sealed class BitCellAttribute : A { public BitCellAttribute() : base(K.BitCell) {} }

    public sealed class LoPosAttribute : A { public LoPosAttribute() : base(K.LoPos) {} }

    public sealed class HiPosAttribute : A { public HiPosAttribute() : base(K.HiPos) {} }

    public sealed class HiSegAttribute : A { public HiSegAttribute() : base(K.HiSeg) {} }

    public sealed class LoSegAttribute : A { public LoSegAttribute() : base(K.LoSeg) {} }

    public sealed class ZHiAttribute : A { public ZHiAttribute() : base(K.ZHi) {} }

    public sealed class PackAttribute : A { public PackAttribute() : base(K.Pack) {} }

    public sealed class UnpackAttribute : A { public UnpackAttribute() : base(K.Unpack) {} }

    public sealed class HProdAttribute : A { public HProdAttribute() : base(K.HProd) {} }

    public sealed class TestZnCAttribute : A { public TestZnCAttribute() : base(K.TestZnC) {} }

    public sealed class SameAttribute : A { public SameAttribute() : base(K.Same) {} }

    public sealed class EffWidthAttribute : A { public EffWidthAttribute() : base(K.EffWidth) {} }

    public sealed class EffSizeAttribute : A { public EffSizeAttribute() : base(K.EffSize) {} }

    public sealed class BitClearAttribute : A { public BitClearAttribute() : base(K.BitClear) {} }

    public sealed class MoveMaskAttribute : A { public MoveMaskAttribute() : base(K.MoveMask) {} }

    public sealed class ZeroExtendAttribute : A { public ZeroExtendAttribute() : base(K.ZeroExtend) {} }

    public sealed class SignExtendAttribute : A { public SignExtendAttribute() : base(K.SignExtend) {} }

    public sealed class EnableAttribute : A { public EnableAttribute() : base(K.Enable) {} }

    public sealed class DisableAttribute : A { public DisableAttribute() : base(K.Disable) {} }

    public sealed class ByteswapAttribute : A { public ByteswapAttribute() : base(K.Byteswap) {} }

    public sealed class BlsrAttribute : A { public BlsrAttribute() : base(K.Blsr) {} }

    public sealed class BlsiAttribute : A { public BlsiAttribute() : base(K.Blsi) {} }
}