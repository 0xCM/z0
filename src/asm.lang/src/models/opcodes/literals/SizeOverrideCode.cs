//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    public enum SizeOverrideCode
    {
        None = 0,

        /// <summary>
        /// Specifies the <see cref='x66'/> operand data size override code
        /// </summary>
        Operand = x66,

        /// <summary>
        /// Specifies the <see cref='x67'/> operand address size override code, which allows programs to switch between 16- and 32-bit addressing
        /// </summary>
        Address = x67,
    }
}