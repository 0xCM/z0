//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    /// <summary>
    /// Defines REX field identifiers
    /// </summary>
    public enum RexFieldIndex : byte
    {
        B = 0,

        X = 1,

        R = 2,
        
        W = 3,

        Code = 4,
    }
}