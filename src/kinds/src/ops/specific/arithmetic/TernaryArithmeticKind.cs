//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    /// <summary>
    /// Identifies binary arithmetic operators classes
    /// </summary>
    public enum TernaryArithmeticKind : ulong
    {
        None = 0,

        Fma = Id.Fma,

        ModMul
    }
}
