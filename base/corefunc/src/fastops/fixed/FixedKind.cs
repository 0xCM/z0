//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public enum FixedKind : uint
    {
        None = 0,
        
        Fixed8,

        Fixed16,

        Fixed32,

        Fixed64,

        Fixed128,

        Fixed256,
        
        Fixed512,

    }

}