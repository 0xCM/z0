//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static RegisterWidth;
    using static RegisterRole;    

    /// <summary>
    /// Factors width into role classifications
    /// </summary>
    [Flags]
    public enum RegisterRoleWidth : ulong
    {
        /// <summary>
        /// Classifies an 8-bit general-purpose register
        ///</summary>
        GP8 = GP | W8,

        /// <summary>
        /// Classifies a 16-bit general-purpose register
        ///</summary>
        GP16 = GP | W16,

        /// <summary>
        /// Classifies a 32-bit general-purpose register
        ///</summary>
        GP32 = GP | W32,

        /// <summary>
        /// Classifies a 64-bit general-purpose register
        ///</summary>
        GP64 = GP | W64,

        /// <summary>
        /// Classifies a 128-bit vector register
        ///</summary>
        Xmm = Vec | W128,

        /// <summary>
        /// Classifies a 256-bit vector register
        ///</summary>
        Ymm = Vec | W256,

        /// <summary>
        /// Classifies a 512-bit vector register
        ///</summary>
        Zmm = Vec | W512,
    }
}