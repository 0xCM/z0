//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    using K = RegisterKind;

    /// <summary>
    /// The segment override codes as specified by Intel Vol II, 2.1.1
    /// </summary>
    public enum SegOverrideCode : byte
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
    }
}