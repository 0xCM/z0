//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = Pow2;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,15
    /// </summary>
    [Flags, LiteralSet(typeof(Pow2))]
    public enum Pow2x16 : ushort
    {
        /// <summary>
        /// 2^0 = 1
        /// </summary>
        P2ᐞ00 = K.T00,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        P2ᐞ01 = K.T01,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        P2ᐞ02 = K.T02,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        P2ᐞ03 = K.T03,

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        P2ᐞ04 = K.T04,

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        P2ᐞ05 = K.T05,

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        P2ᐞ06 = K.T06,

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        P2ᐞ07 = K.T07,

        /// <summary>
        /// 2^8 = 256
        /// </summary>
        P2ᐞ08 = K.T08,

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        P2ᐞ09 = K.T09,

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        P2ᐞ10 = K.T10,

        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        P2ᐞ11 = K.T11,

        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        P2ᐞ12 = K.T12,

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        P2ᐞ13 = K.T13,

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        P2ᐞ14 = K.T14,

        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        P2ᐞ15 = K.T15,
    }
}