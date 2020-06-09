//-----------------------------------------------------------------------------
// Copyright   :  Microsoft
// License     : MIT via .Net Foundation
// Extracted from System.Reflection.MetadataReader library code
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    partial class MetadataFlags
    {
        /// <summary>
        /// These constants are all in the byte range and apply to the interpretation of <see cref="Handle.VType"/>,
        /// </summary>
        internal static class HandleType
        {
            internal const uint Module = (uint)TableIndex.Module;
            internal const uint TypeRef = (uint)TableIndex.TypeRef;
            internal const uint TypeDef = (uint)TableIndex.TypeDef;
            internal const uint FieldDef = (uint)TableIndex.Field;
            internal const uint MethodDef = (uint)TableIndex.MethodDef;
            internal const uint ParamDef = (uint)TableIndex.Param;
            internal const uint InterfaceImpl = (uint)TableIndex.InterfaceImpl;
            internal const uint MemberRef = (uint)TableIndex.MemberRef;
            internal const uint Constant = (uint)TableIndex.Constant;
            internal const uint CustomAttribute = (uint)TableIndex.CustomAttribute;
            internal const uint DeclSecurity = (uint)TableIndex.DeclSecurity;
            internal const uint Signature = (uint)TableIndex.StandAloneSig;
            internal const uint EventMap = (uint)TableIndex.EventMap;
            internal const uint Event = (uint)TableIndex.Event;
            internal const uint PropertyMap = (uint)TableIndex.PropertyMap;
            internal const uint Property = (uint)TableIndex.Property;
            internal const uint MethodSemantics = (uint)TableIndex.MethodSemantics;
            internal const uint MethodImpl = (uint)TableIndex.MethodImpl;
            internal const uint ModuleRef = (uint)TableIndex.ModuleRef;
            internal const uint TypeSpec = (uint)TableIndex.TypeSpec;
            internal const uint Assembly = (uint)TableIndex.Assembly;
            internal const uint AssemblyRef = (uint)TableIndex.AssemblyRef;
            internal const uint File = (uint)TableIndex.File;
            internal const uint ExportedType = (uint)TableIndex.ExportedType;
            internal const uint ManifestResource = (uint)TableIndex.ManifestResource;
            internal const uint NestedClass = (uint)TableIndex.NestedClass;
            internal const uint GenericParam = (uint)TableIndex.GenericParam;
            internal const uint MethodSpec = (uint)TableIndex.MethodSpec;
            internal const uint GenericParamConstraint = (uint)TableIndex.GenericParamConstraint;

            // debug tables:
            internal const uint Document = (uint)TableIndex.Document;
            internal const uint MethodDebugInformation = (uint)TableIndex.MethodDebugInformation;
            internal const uint LocalScope = (uint)TableIndex.LocalScope;
            internal const uint LocalVariable = (uint)TableIndex.LocalVariable;
            internal const uint LocalConstant = (uint)TableIndex.LocalConstant;
            internal const uint ImportScope = (uint)TableIndex.ImportScope;
            internal const uint AsyncMethod = (uint)TableIndex.StateMachineMethod;
            internal const uint CustomDebugInformation = (uint)TableIndex.CustomDebugInformation;

            internal const uint UserString = 0x70;     // #UserString heap

            // The following values never appear in a token stored in metadata,
            // they are just helper values to identify the type of a handle.
            // Note, however, that even though they do not come from the spec,
            // they are surfaced as public constants via HandleKind enum and
            // therefore cannot change!

            internal const uint Blob = 0x71;        // #Blob heap
            internal const uint Guid = 0x72;        // #Guid heap

            // #String heap and its modifications
            //
            // Multiple values are reserved for string handles so that we can encode special
            // handling with more than just the virtual bit. See StringHandleType for how
            // the two extra bits are actually interpreted. The extra String1,2,3 values here are
            // not used directly, but serve as a reminder that they are not available for use
            // by another handle type.
            internal const uint String  = 0x78;
            internal const uint String1 = 0x79;
            internal const uint String2 = 0x7a;
            internal const uint String3 = 0x7b;

            // Namespace handles also have offsets into the #String heap (when non-virtual)
            // to their full name. However, this is an implementation detail and they are
            // surfaced with first-class HandleKind.Namespace and strongly-typed NamespaceHandle.
            internal const uint Namespace = 0x7c;

            internal const uint HeapMask = 0x70;
            internal const uint TypeMask = 0x7F;

            /// <summary>
            /// Use the highest bit to mark tokens that are virtual (synthesized).
            /// We create virtual tokens to represent projected WinMD entities.
            /// </summary>
            internal const uint VirtualBit = 0x80;

            /// <summary>
            /// In the case of string handles, the two lower bits that (in addition to the
            /// virtual bit not included in this mask) encode how to obtain the string value.
            /// </summary>
            internal const uint NonVirtualStringTypeMask = 0x03;
        }

    }
}