//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using H = Hex8Seq;

    partial struct AsmCodes
    {
        /// <summary>
        /// Defines the mandatory prefix codes as specified by Intel Vol II, 2.1.2
        /// </summary>
        public enum MandatoryPrefixCode : byte
        {
            None = 0,

            [Symbol("66")]
            x66 = H.x66,

            [Symbol("f2")]
            F2 = H.xf2,

            [Symbol("f3")]
            F3 = H.xf3,
        }
    }
}