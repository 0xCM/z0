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

    /// <summary>
    /// Clasifies primitive types
    /// </summary>
    [Flags]
    public enum PrimalWidth : uint
    {    

        w8 = 8,

        w16 = 16,

        w32 = 32,

        w64 = 64

    }

}