// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0.Schemas.Ecma
{
    /// <summary>
    /// These constants are all in the byte range and apply to the interpretation of <see cref="Handle.VType"/>,
    /// </summary>
    public readonly struct HandleType
    {
        public const uint Module = (uint)ClrTableKind.Module;

        public const uint TypeRef = (uint)ClrTableKind.TypeRef;

        public const uint TypeDef = (uint)ClrTableKind.TypeDef;

        public const uint FieldDef = (uint)ClrTableKind.Field;

        public const uint MethodDef = (uint)ClrTableKind.MethodDef;

        public const uint ParamDef = (uint)ClrTableKind.Param;

        public const uint InterfaceImpl = (uint)ClrTableKind.InterfaceImpl;

        public const uint MemberRef = (uint)ClrTableKind.MemberRef;

        public const uint Constant = (uint)ClrTableKind.Constant;

        public const uint CustomAttribute = (uint)ClrTableKind.CustomAttribute;

        public const uint DeclSecurity = (uint)ClrTableKind.DeclSecurity;

        public const uint Signature = (uint)ClrTableKind.StandAloneSig;

        public const uint EventMap = (uint)ClrTableKind.EventMap;

        public const uint Event = (uint)ClrTableKind.Event;

        public const uint PropertyMap = (uint)ClrTableKind.PropertyMap;

        public const uint Property = (uint)ClrTableKind.Property;

        public const uint MethodSemantics = (uint)ClrTableKind.MethodSemantics;

        public const uint MethodImpl = (uint)ClrTableKind.MethodImpl;

        public const uint ModuleRef = (uint)ClrTableKind.ModuleRef;

        public const uint TypeSpec = (uint)ClrTableKind.TypeSpec;

        public const uint Assembly = (uint)ClrTableKind.Assembly;

        public const uint AssemblyRef = (uint)ClrTableKind.AssemblyRef;

        public const uint File = (uint)ClrTableKind.File;

        public const uint ExportedType = (uint)ClrTableKind.ExportedType;

        public const uint ManifestResource = (uint)ClrTableKind.ManifestResource;

        public const uint NestedClass = (uint)ClrTableKind.NestedClass;

        public const uint GenericParam = (uint)ClrTableKind.GenericParam;

        public const uint MethodSpec = (uint)ClrTableKind.MethodSpec;

        public const uint GenericParamConstraint = (uint)ClrTableKind.GenericParamConstraint;

        // debug tables:
        public const uint Document = (uint)ClrTableKind.Document;

        public const uint MethodDebugInformation = (uint)ClrTableKind.MethodDebugInformation;

        public const uint LocalScope = (uint)ClrTableKind.LocalScope;

        public const uint LocalVariable = (uint)ClrTableKind.LocalVariable;

        public const uint LocalConstant = (uint)ClrTableKind.LocalConstant;

        public const uint ImportScope = (uint)ClrTableKind.ImportScope;

        public const uint AsyncMethod = (uint)ClrTableKind.StateMachineMethod;

        public const uint CustomDebugInformation = (uint)ClrTableKind.CustomDebugInformation;

        public const uint UserString = 0x70;     // #UserString heap

        // The following values never appear in a token stored in metadata,
        // they are just helper values to identify the type of a handle.
        // Note, however, that even though they do not come from the spec,
        // they are surfaced as public constants via HandleKind enum and
        // therefore cannot change!

        public const uint Blob = 0x71;        // #Blob heap

        public const uint Guid = 0x72;        // #Guid heap

        // #String heap and its modifications
        //
        // Multiple values are reserved for string handles so that we can encode special
        // handling with more than just the virtual bit. See StringHandleType for how
        // the two extra bits are actually interpreted. The extra String1,2,3 values here are
        // not used directly, but serve as a reminder that they are not available for use
        // by another handle type.
        public const uint String  = 0x78;

        public const uint String1 = 0x79;

        public const uint String2 = 0x7a;

        public const uint String3 = 0x7b;

        // Namespace handles also have offsets into the #String heap (when non-virtual)
        // to their full name. However, this is an implementation detail and they are
        // surfaced with first-class HandleKind.Namespace and strongly-typed NamespaceHandle.
        public const uint Namespace = 0x7c;

        public const uint HeapMask = 0x70;

        public const uint TypeMask = 0x7F;

        /// <summary>
        /// Use the highest bit to mark tokens that are virtual (synthesized).
        /// We create virtual tokens to represent projected WinMD entities.
        /// </summary>
        public const uint VirtualBit = 0x80;

        /// <summary>
        /// In the case of string handles, the two lower bits that (in addition to the
        /// virtual bit not included in this mask) encode how to obtain the string value.
        /// </summary>
        public const uint NonVirtualStringTypeMask = 0x03;
    }
}