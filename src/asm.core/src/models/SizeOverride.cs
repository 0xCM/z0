//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    partial struct AsmCodes
    {
        public enum SizeOverride
        {
            None = 0,

            /// <summary>
            /// Operand size override
            /// </summary>
            /// <remarks>
            /// The operand-size override prefix allows a program to switch between 16- and 32-bit operand sizes.
            /// Either size can be the default; use of the prefix selects the non-default size
            /// </remarks>
            [Symbol("x66","Operand size override")]
            OPSZ = x66,

            /// <summary>
            /// Address size override
            /// </summary>
            /// <remarks>
            /// The address-size override prefix allows programs to switch between 16- and 32-bit addressing.
            /// Either size can be the default; the prefix selects the non-default size
            /// </remarks>
            [Symbol("x64", "Address size override")]
            ADSZ = x67,
        }
    }
}