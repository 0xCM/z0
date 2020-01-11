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


    public enum PrimalId : uint
    {
        U8 = (1u << 16),

        I8 = (2u << 16),

        U16 = (4u << 16),

        I16 = (8u << 16),

        U32 = (16u << 16),

        I32 = (32u << 16),

        U64 = (64u << 16),

        I64 = (128u << 16),
        
        F32 = (512u << 16),

        F64 = (1024u << 16)

    }
}