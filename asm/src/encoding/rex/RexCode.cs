//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;         

    /// <summary>
    /// Defines the available REX prefixes
    /// </summary>
    public enum RexCode : byte
    {
        None = 0,
        
        REX40h = 1,
        
        REX41h = 2,
        
        REX42h = 3,
        
        REX43h = 4,

        REX44h = 5,

        REX45h = 6,

        REX46h = 7,

        REX47h = 8,

        REX48h = 9,

        REX49h = 10,

        REX4Ah = 11,

        REX4Bh = 12,

        REX4Ch = 13,

        REX4Dh = 14,

        REX4Eh = 15,

        REX4Fh = 16,
    }

}