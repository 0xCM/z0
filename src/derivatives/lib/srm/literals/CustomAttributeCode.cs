//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using static Part;

    public enum CustomAttributeCode : uint
    {
        NumberOfBits = 2,

        Method = 0x00000000,

        Field = 0x00000001,

        TypeRef = 0x00000002,

        TypeDef = 0x00000003,

        Param = 0x00000004,

        InterfaceImpl = 0x00000005,

        MemberRef = 0x00000006,

        Module = 0x00000007,

        DeclSecurity = 0x00000008,

        Property = 0x00000009,

        Event = 0x0000000A,

        StandAloneSig = 0x0000000B,

        ModuleRef = 0x0000000C,

        TypeSpec = 0x0000000D,

        Assembly = 0x0000000E,

        AssemblyRef = 0x0000000F,

        File = 0x00000010,

        ExportedType = 0x00000011,

        ManifestResource = 0x00000012,

        GenericParameter = 0x00000013,

        GenericParameterConstraint = 0x00000014,

        MethodSpec = 0x00000015,
    }


}