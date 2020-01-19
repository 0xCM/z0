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
    /// Clasifies types
    /// </summary>
    [Flags]
    public enum TypeKind : uint
    {    
        None = 0,
        
        Primal = 1,

        Block = 2,

        Vector = 4

    }

}