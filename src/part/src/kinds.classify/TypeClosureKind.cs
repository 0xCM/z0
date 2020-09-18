//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum TypeClosureKind : byte
    {
        None = 0,

        Numeric = 1,

        Natural = 2,

        Imm8 = 3,

        Width = 4,

        Fixed = 5,

        NaturalPairs = 6,

        Opaque = 7,
    }
}