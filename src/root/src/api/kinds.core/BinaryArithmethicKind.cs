//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Classifies elementary binary arithmetic operations
    /// </summary>
    public enum BinaryArithmeticKind : byte
    {
        None,

        Add,

        Sub,

        Mul,

        Div,

        Mod,
    }
}