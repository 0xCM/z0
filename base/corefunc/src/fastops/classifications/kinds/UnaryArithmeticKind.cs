//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classifies unary arithmetic operators
    /// </summary>
    public enum UnaryArithmeticKind : byte
    {
        Inc = 1,

        Dec = 2,

        Negate = 3,

    }
}