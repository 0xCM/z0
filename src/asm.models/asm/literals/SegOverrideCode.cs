//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static Hex8Kind;

    using K = RegisterKind;

    public enum SegOverrideCode : byte
    {
        None = 0,

        /// <summary>
        /// Specifies the override code for the <see cref='K.CS'/> register
        /// </summary>
        CS = x2e,

        /// <summary>
        /// Specifies the override code for the <see cref='K.SS'/> register
        /// </summary>
        SS = x36,

        /// <summary>
        /// Specifies the override code for the <see cref='K.DS'/> register
        /// </summary>
        DS = x3e,

        /// <summary>
        /// Specifies the override code for the <see cref='K.ES'/> register
        /// </summary>
        ES = x26,

        /// <summary>
        /// Specifies the override code for the <see cref='K.FS'/> register
        /// </summary>
        FS = x64,

        /// <summary>
        /// Specifies the override code for the <see cref='K.GS'/> register
        /// </summary>
        GS = x65        
    }
}