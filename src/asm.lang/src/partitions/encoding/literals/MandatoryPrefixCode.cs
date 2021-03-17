//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using H = Hex8Seq;

    /// <summary>
    /// Defines the mandatory prefix codes as specified by Intel Vol II, 2.1.2
    /// </summary>
    public enum MandatoryPrefixCode : byte
    {
        None = 0,

        x66 = H.x66,

        xf2 = H.xf2,

        xf3 = H.xf3,
    }
}