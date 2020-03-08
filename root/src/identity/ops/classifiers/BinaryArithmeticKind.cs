//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    /// <summary>
    /// Classsifies binary arithmetic operators
    /// </summary>
    public enum BinaryArithmeticKind : byte
    {

        Add = 1,

        Sub = 2,

        Mul = 3,

        Div = 4,

        Mod = 5,
    }    
}