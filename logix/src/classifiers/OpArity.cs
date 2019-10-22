//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public enum OpArityKind
    {
        Nullary = 0,

        Unary = 1,

        Binary = 2,

        Ternary = 3,

        Sequence = 4
    }


}