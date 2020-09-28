//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum TableIndex : byte
    {
        Module = (byte)0,

        TypeRef = (byte)1,

        TypeDef = (byte)2,

        FieldPtr = (byte)3,

        Field = (byte)4,

        MethodPtr = (byte)5,

        MethodDef = (byte)6,

        ParamPtr = (byte)7,

        Param = (byte)8,

        InterfaceImpl = (byte)9,

        MemberRef = (byte)10,

        Constant = (byte)11,

        CustomAttribute = (byte)12,

        FieldMarshal = (byte)13,

        DeclSecurity = (byte)14,

        ClassLayout = (byte)15,

        FieldLayout = (byte)16,

        StandAloneSig = (byte)17,

        EventMap = (byte)18,

        EventPtr = (byte)19,

        Event = (byte)20,

        PropertyMap = (byte)21,

        PropertyPtr = (byte)22,

        Property = (byte)23,

        MethodSemantics = (byte)24,

        MethodImpl = (byte)25,

        ModuleRef = (byte)26,

        TypeSpec = (byte)27,

        ImplMap = (byte)28,

        FieldRva = (byte)29,

        EncLog = (byte)30,

        EncMap = (byte)31,

        Assembly = (byte)32,

        AssemblyProcessor = (byte)33,

        AssemblyOS = (byte)34,

        AssemblyRef = (byte)35,

        AssemblyRefProcessor = (byte)36,

        AssemblyRefOS = (byte)37,

        File = (byte)38,

        ExportedType = (byte)39,

        ManifestResource = (byte)40,

        NestedClass = (byte)41,

        GenericParam = (byte)42,

        MethodSpec = (byte)43,

        GenericParamConstraint = (byte)44,

        Document = (byte)48,

        MethodDebugInformation = (byte)49,

        LocalScope = (byte)50,

        LocalVariable = (byte)51,

        LocalConstant = (byte)52,

        ImportScope = (byte)53,

        StateMachineMethod = (byte)54,

        CustomDebugInformation = (byte)55,

        UserString = 0x70,
    }
}