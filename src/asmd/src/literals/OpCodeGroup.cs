//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static HexKind3i;

    /// <summary>
    /// Defines an index in the range 0 - 7 that specifies an index of the reg field of a ModRM byte
    /// </summary>
    public enum OpCodeGroup : sbyte
    {        
        None = -1,

        G0 = x0i,

        G1 = x1i,

        G2 = x2i,

        G3 = x3i,

        G4 = x4i,

        G5 = x5i,

        G6 = x6i,

        G7 = x7i,
    }
}