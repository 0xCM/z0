//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    using D = RexPrefixDescriptions;

    /// <summary>
    /// Defines the rex prefix codes
    /// </summary>
    [PrefixCodes]
    public enum RexPrefixCode : byte
    {
        None = 0,

        /// <summary>
        /// Defines the <see cref='x40'/> prefix [0100 0000]
        /// </summary>
        [PrefixCode(D.Rex40)]
        Rex40 = x40,

        /// <summary>
        /// Defines the <see cref='x41'/> prefix [0100 0001]
        /// </summary>
        [PrefixCode(D.Rex41)]
        RexB = x41,

        /// <summary>
        /// Defines the <see cref='x42'/> prefix [0100 0010]
        /// </summary>
        [PrefixCode(D.Rex42)]
        Rex42 = x42,

        /// <summary>
        /// Defines the <see cref='x43'/> prefix [0100 0011]
        /// </summary>
        [PrefixCode(D.Rex43)]
        Rex43 = x43,

        /// <summary>
        /// Defines the <see cref='x44'/> prefix [0100 0100]
        /// </summary>
        [PrefixCode(D.Rex44)]
        RexR = x44,

        /// <summary>
        /// Defines the <see cref='x45'/> prefix [0100 0101]
        /// </summary>
        [PrefixCode(D.Rex45)]
        Rex45 = x45,

        /// <summary>
        /// Defines the <see cref='x46'/> prefix [0100 0110]
        /// </summary>
        [PrefixCode(D.Rex46)]
        Rex46 = x46,

        /// <summary>
        /// Defines the <see cref='x47'/> prefix [0100 0111]
        /// </summary>
        [PrefixCode(D.Rex47)]
        Rex47 = x47,

        /// <summary>
        /// Defines the <see cref='x48'/> prefix [0100 1000]
        /// </summary>
        [PrefixCode(D.Rex48)]
        RexW = x48,

        /// <summary>
        /// Defines the <see cref='x49'/> prefix [0100 1001]
        /// </summary>
        [PrefixCode(D.Rex49)]
        RexWB = x49,

        /// <summary>
        /// Defines the <see cref='x4a'/> prefix [0100 1010]
        /// </summary>
        [PrefixCode(D.Rex4A)]
        RexWX = x4a,

        /// <summary>
        /// Defines the <see cref='x4b'/> prefix [0100 1011]
        /// </summary>
        [PrefixCode(D.Rex4B)]
        RexXB = x4b,

        /// <summary>
        /// Defines the <see cref='x4c'/> prefix [0100 1100]
        /// </summary>
        [PrefixCode(D.Rex4C)]
        RexWR = x4c,

        /// <summary>
        /// Defines the <see cref='x4d'/> prefix [0100 1101]
        /// </summary>
        [PrefixCode(D.Rex4D)]
        RexWRB = x4d,

        /// <summary>
        /// Defines the <see cref='x4e'/> prefix [0100 1110]
        /// </summary>
        [PrefixCode(D.Rex4E)]
        RexWRX = x4e,

        /// <summary>
        /// Defines the <see cref='x4f'/> prefix [0100 1111]
        /// </summary>
        [PrefixCode(D.Rex4F)]
        RexWRXB = x4f,
    }
}