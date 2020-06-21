//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using AF = ArtifactFacetKind;

    [Flags]
    public enum NumericFacetKind : ulong
    {
        None = 0,

        U8 = AF.U8,

        U16 = AF.U16,

        U32 = AF.U32,

        U64 = AF.U64,

        I8 = AF.U8,

        I16 = AF.I16,

        I32 = AF.I32,

        I64 = AF.I64,
        
        F32 = AF.F32,

        F64 = AF.F64,
    }
}