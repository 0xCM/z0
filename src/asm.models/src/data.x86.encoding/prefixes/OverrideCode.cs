//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    using K = RegisterKind;

    public enum OverrideCode : byte
    {
        None = 0,

        /// <summary>
        /// Specifies the override code for the <see cref='K.CS'/> register
        /// </summary>
        CS = x2e,

        /// <summary>
        /// Specifies the <see cref='x36'/> override code for the <see cref='K.SS'/> register
        /// </summary>
        SS = x36,

        /// <summary>
        /// Specifies the <see cref='x3e'/> override code for the <see cref='K.DS'/> register
        /// </summary>
        DS = x3e,

        /// <summary>
        /// Specifies the <see cref='x26'/> override code for the <see cref='K.ES'/> register
        /// </summary>
        ES = x26,

        /// <summary>
        /// Specifies the <see cref='x64'/> override code for the <see cref='K.FS'/> register
        /// </summary>
        FS = x64,

        /// <summary>
        /// Specifies the <see cref='x65'/> override code for the <see cref='K.GS'/> register
        /// </summary>
        GS = x65,

        /// <summary>
        /// Specifies the <see cref='x66'/> operand data size override code
        /// </summary>
        Operand = x66,

        /// <summary>
        /// Specifies the <see cref='x67'/> operand address size override code
        /// </summary>
        Address = x67,
    }
}