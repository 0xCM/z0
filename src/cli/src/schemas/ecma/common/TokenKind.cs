// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0.Schemas.Ecma
{
    public enum TokenKind : byte
    {
        Module = (byte)ClrTableKind.Module,

        TypeRef = (byte)ClrTableKind.TypeRef,

        TypeDef = (byte)ClrTableKind.TypeDef,

        FieldDef = (byte)ClrTableKind.Field,

        MethodDef = (byte)ClrTableKind.MethodDef,

        ParamDef = (byte)ClrTableKind.Param,

        InterfaceImpl = (byte)ClrTableKind.InterfaceImpl,

        MemberRef = (byte)ClrTableKind.MemberRef,

        Constant = (byte)ClrTableKind.Constant,

        CustomAttribute = (byte)ClrTableKind.CustomAttribute,

        DeclSecurity = (byte)ClrTableKind.DeclSecurity,

        Signature = (byte)ClrTableKind.StandAloneSig,

        EventMap = (byte)ClrTableKind.EventMap,

        Event = (byte)ClrTableKind.Event,

        PropertyMap = (byte)ClrTableKind.PropertyMap,

        Property = (byte)ClrTableKind.Property,

        MethodSemantics = (byte)ClrTableKind.MethodSemantics,

        MethodImpl = (byte)ClrTableKind.MethodImpl,

        ModuleRef = (byte)ClrTableKind.ModuleRef,

        TypeSpec = (byte)ClrTableKind.TypeSpec,

        Assembly = (byte)ClrTableKind.Assembly,

        AssemblyRef = (byte)ClrTableKind.AssemblyRef,

        File = (byte)ClrTableKind.File,

        ExportedType = (byte)ClrTableKind.ExportedType,

        ManifestResource = (byte)ClrTableKind.ManifestResource,

        NestedClass = (byte)ClrTableKind.NestedClass,

        GenericParam = (byte)ClrTableKind.GenericParam,

        MethodSpec = (byte)ClrTableKind.MethodSpec,

        GenericParamConstraint = (byte)ClrTableKind.GenericParamConstraint,

        Document = (byte)ClrTableKind.Document,

        MethodDebugInformation = (byte)ClrTableKind.MethodDebugInformation,

        LocalScope = (byte)ClrTableKind.LocalScope,

        LocalVariable = (byte)ClrTableKind.LocalVariable,

        LocalConstant = (byte)ClrTableKind.LocalConstant,

        ImportScope = (byte)ClrTableKind.ImportScope,

        AsyncMethod = (byte)ClrTableKind.StateMachineMethod,

        CustomDebugInformation = (byte)ClrTableKind.CustomDebugInformation,

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