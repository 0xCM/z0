//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;

    [Flags]
    public enum UnaryArithmeticOpKind : uint
    {
        Inc = 1,

        Dec = Inc << 1,

        Negate = Dec << 1,

    }
}