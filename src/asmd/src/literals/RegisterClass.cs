//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    public enum RegisterClass : byte
    {
        GP = 1,

        /// <summary>
        /// General-purpose numbered?
        /// </summary>
        GPN = 2,
        
        XMM = 3,

        YMM = 4,

        ZMM = 5
    }
}