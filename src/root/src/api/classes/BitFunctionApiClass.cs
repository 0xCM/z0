//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiClass;

    /// <summary>
    /// Identifies bitwise operations in an arity-neutral way
    /// </summary>
    [ApiClass]
    public enum BitFunctionApiClass : ushort
    {
        None = 0,

        TestC = Id.TestC,

        TestZ = Id.TestZ,

        Ntz = Id.Ntz,

        Nlz = Id.Nlz,

        Pop = Id.Pop,

        Mux = Id.Mux,

        Scatter = Id.Scatter,

        Gather = Id.Gather,

        Mix = Id.Mix,

        Rank = Id.Rank,

        Extract = Id.Extract,

        TestBit = Id.TestBit,

        SetBit = Id.SetBit,

        TestBits = Id.TestBits,

        Stitch = Id.Stitch,

        BitCell = Id.BitCell,

        LoPos = Id.LoPos,

        HiPos = Id.HiPos,

        HiSeg = Id.HiSeg,

        LoSeg = Id.LoSeg,

        ZHi = Id.ZHi,

        Pack = Id.Pack,

        Unpack = Id.Unpack,

        HProd = Id.HProd,

        TestZnC = Id.TestZnC,

        Same = Id.Same,

        EffWidth = Id.EffWidth,

        EffSize = Id.EffSize,

        BitClear = Id.BitClear,

        MoveMask = Id.MoveMask,

        ZeroExtend = Id.ZeroExtend,

        SignExtend = Id.SignExtend,

        Enable = Id.Enable,

        Disable = Id.Disable,

        Byteswap = Id.Byteswap,
    }
}