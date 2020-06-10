//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    [FieldWidth(8)]
    public enum RegisterClass : byte
    {
        GP = 1,

        /// <summary>
        /// General-purpose numbered?
        /// </summary>
        GPN = 2,
        
        SEG = 3,

        XMM = 10,

        YMM = 11,

        ZMM = 12,
        
    }
}