//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;

    [Flags]
    public enum FieldFlags : ushort
    {
        CompilerControlledAccess = 0x0000,

        PrivateAccess = 0x0001,

        FamilyAndAssemblyAccess = 0x0002,

        AssemblyAccess = 0x0003,

        FamilyAccess = 0x0004,

        FamilyOrAssemblyAccess = 0x0005,

        PublicAccess = 0x0006,

        AccessMask = 0x0007,

        StaticContract = 0x0010,

        InitOnlyContract = 0x0020,

        LiteralContract = 0x0040,

        NotSerializedContract = 0x0080,

        SpecialNameImpl = 0x0200,

        PInvokeImpl = 0x2000,

        RTSpecialNameReserved = 0x0400,

        HasFieldMarshalReserved = 0x1000,

        HasDefaultReserved = 0x8000,

        HasFieldRVAReserved = 0x0100,

        //  Load flags
        FieldLoaded = 0x4000,
    }

}