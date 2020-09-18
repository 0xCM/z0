//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Id = ApiKeyId;

    /// <summary>
    /// Classifies unary arithmetic operators
    /// </summary>
    public enum UnaryArithmeticApiKey : ushort
    {
        None = 0,

        Inc = Id.Inc,

        Dec = Id.Dec,

        Negate = Id.Negate,

        Abs = Id.Abs,

        Square = Id.Square,

        Sqrt = Id.Sqrt,
    }
}