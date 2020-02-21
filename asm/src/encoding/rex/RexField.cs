//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

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

    public enum RexFieldWidth : byte
    {
        B = 1,

        X = 1,

        R = 1,
        
        W = 1,

        Code = 4,
    }    
}