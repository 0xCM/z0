// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0.Schemas.Ecma
{
    public enum TokenKind : byte
    {
        Module = (byte)TableIndex.Module,

        TypeRef = (byte)TableIndex.TypeRef,

        TypeDef = (byte)TableIndex.TypeDef,

        FieldDef = (byte)TableIndex.Field,

        MethodDef = (byte)TableIndex.MethodDef,

        ParamDef = (byte)TableIndex.Param,

        InterfaceImpl = (byte)TableIndex.InterfaceImpl,

        MemberRef = (byte)TableIndex.MemberRef,

        Constant = (byte)TableIndex.Constant,

        CustomAttribute = (byte)TableIndex.CustomAttribute,

        DeclSecurity = (byte)TableIndex.DeclSecurity,

        Signature = (byte)TableIndex.StandAloneSig,

        EventMap = (byte)TableIndex.EventMap,

        Event = (byte)TableIndex.Event,

        PropertyMap = (byte)TableIndex.PropertyMap,

        Property = (byte)TableIndex.Property,

        MethodSemantics = (byte)TableIndex.MethodSemantics,

        MethodImpl = (byte)TableIndex.MethodImpl,

        ModuleRef = (byte)TableIndex.ModuleRef,

        TypeSpec = (byte)TableIndex.TypeSpec,

        Assembly = (byte)TableIndex.Assembly,

        AssemblyRef = (byte)TableIndex.AssemblyRef,

        File = (byte)TableIndex.File,

        ExportedType = (byte)TableIndex.ExportedType,

        ManifestResource = (byte)TableIndex.ManifestResource,

        NestedClass = (byte)TableIndex.NestedClass,

        GenericParam = (byte)TableIndex.GenericParam,

        MethodSpec = (byte)TableIndex.MethodSpec,

        GenericParamConstraint = (byte)TableIndex.GenericParamConstraint,

        Document = (byte)TableIndex.Document,

        MethodDebugInformation = (byte)TableIndex.MethodDebugInformation,

        LocalScope = (byte)TableIndex.LocalScope,

        LocalVariable = (byte)TableIndex.LocalVariable,

        LocalConstant = (byte)TableIndex.LocalConstant,

        ImportScope = (byte)TableIndex.ImportScope,

        AsyncMethod = (byte)TableIndex.StateMachineMethod,

        CustomDebugInformation = (byte)TableIndex.CustomDebugInformation,

        UserString = 0x70,     // #UserString heap

        // The following values never appear in a token stored in metadata,
        // they are just helper values to identify the type of a handle.
        // Note, however, that even though they do not come from the spec,
        // they are surfaced as public constants via HandleKind enum and
        // therefore cannot change!

        Blob = 0x71,        // #Blob heap

        Guid = 0x72,        // #Guid heap
    }
}