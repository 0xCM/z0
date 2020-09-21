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
    public enum TypeDefFlags : uint
    {
        PrivateAccess = 0x00000000,

        PublicAccess = 0x00000001,

        NestedPublicAccess = 0x00000002,

        NestedPrivateAccess = 0x00000003,

        NestedFamilyAccess = 0x00000004,

        NestedAssemblyAccess = 0x00000005,

        NestedFamilyAndAssemblyAccess = 0x00000006,

        NestedFamilyOrAssemblyAccess = 0x00000007,

        AccessMask = 0x0000007,

        NestedMask = 0x00000006,

        AutoLayout = 0x00000000,

        SeqentialLayout = 0x00000008,

        ExplicitLayout = 0x00000010,

        LayoutMask = 0x00000018,

        ClassSemantics = 0x00000000,

        InterfaceSemantics = 0x00000020,

        AbstractSemantics = 0x00000080,

        SealedSemantics = 0x00000100,

        SpecialNameSemantics = 0x00000400,

        RTSpecialNameReserved = 0x00000800,

        ImportImplementation = 0x00001000,

        SerializableImplementation = 0x00002000,

        IsForeign = 0x00004000,

        AnsiString = 0x00000000,

        UnicodeString = 0x00010000,

        AutoCharString = 0x00020000,

        StringMask = 0x00030000,

        HasSecurityReserved = 0x00040000,

        BeforeFieldInitImplementation = 0x00100000,

        ForwarderImplementation = 0x00200000,

        DoesNotInheritTypeParameters = 0x10000000
    }
}