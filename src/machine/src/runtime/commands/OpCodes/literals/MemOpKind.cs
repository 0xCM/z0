//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static HexCodes;
    using static Seed;
    using static Memories;
 
    public enum MemOpKind : byte
    {
        None = 0,

        m8 = 0b0001,

        m16 = 0b0010,

        m32 = 0b0011,

        m64 = 0b0100,

        m128 = 0b0101,

        m256 = 0b0100,

        m512 = 0b0111,        
    }
}