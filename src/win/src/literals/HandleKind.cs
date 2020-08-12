//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    public enum HandleKind : byte
    {
        ModuleDefinition = (byte)0,

        TypeReference = (byte)1,

        TypeDefinition = (byte)2,

        FieldDefinition = (byte)4,

        MethodDefinition = (byte)6,

        Parameter = (byte)8,

        InterfaceImplementation = (byte)9,
        
        MemberReference = (byte)10,
        
        Constant = (byte)11,
        
        CustomAttribute = (byte)12,
        
        DeclarativeSecurityAttribute = (byte)14,
        
        StandaloneSignature = (byte)17,
        
        EventDefinition = (byte)20,
        
        PropertyDefinition = (byte)23,
        
        MethodImplementation = (byte)25,
        
        ModuleReference = (byte)26,
        
        TypeSpecification = (byte)27,
        
        AssemblyDefinition = (byte)32,
        
        AssemblyReference = (byte)35,

        AssemblyFile = (byte)38,

        ExportedType = (byte)39,

        ManifestResource = (byte)40,

        GenericParameter = (byte)42,

        MethodSpecification = (byte)43,

        GenericParameterConstraint = (byte)44,

        Document = (byte)48,

        MethodDebugInformation = (byte)49,

        LocalScope = (byte)50,

        LocalVariable = (byte)51,

        LocalConstant = (byte)52,

        ImportScope = (byte)53,

        CustomDebugInformation = (byte)55,

        UserString = (byte)112,

        Blob = (byte)113,

        Guid = (byte)114,

        String = (byte)120,

        NamespaceDefinition = (byte)124,
    }


}