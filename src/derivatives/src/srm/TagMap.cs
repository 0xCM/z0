// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Part;

    using static Tags;

    public readonly struct MetadataHandle<T>
    {
        public readonly T Data;

        [MethodImpl(Inline)]
        public MetadataHandle(T src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator MetadataHandle<T>(T src)
            => new MetadataHandle<T>(src);
    }

    public readonly struct MetadataHandleE
    {
        // bits:
        //     31: IsVirtual
        // 24..30: type
        //  0..23: row id
        public readonly uint Data;

        [MethodImpl(Inline)]
        public MetadataHandleE(uint src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator MetadataHandleE(uint src)
            => new MetadataHandleE(src);

        public uint RowId
        {
            [MethodImpl(Inline)]
            get { return (Data & TokenTypeIds.RIDMask); }
        }

        public uint Type
        {
            [MethodImpl(Inline)]
            get { return Data & TokenTypeIds.TypeMask; }
        }

        public uint VType
        {
            [MethodImpl(Inline)]
            get { return Data & (TokenTypeIds.VirtualBit | TokenTypeIds.TypeMask);}
        }

        public bool IsVirtual
        {
            [MethodImpl(Inline)]
            get { return (Data & TokenTypeIds.VirtualBit) != 0; }
        }

        public bool IsNil
        {
            [MethodImpl(Inline)]
            // virtual handle is never nil
            get { return (Data & (TokenTypeIds.VirtualBit | TokenTypeIds.RIDMask)) == 0; }
        }

        public HandleKind Kind
        {
            [MethodImpl(Inline)]
            get
            {
                // EntityHandles cannot be StringHandles and therefore we do not need
                // to handle stripping the extra non-virtual string type bits here.
                return (HandleKind)(Type >> TokenTypeIds.RowIdBitCount);
            }
        }
    }

    [ApiHost]
    public readonly struct TagMap
    {
        /// <summary>
        /// Calculates a HasCustomAttribute coded index for the specified handle.
        /// </summary>
        /// <param name="handle">
        /// <see cref="MethodDefinitionHandle"/>,
        /// <see cref="FieldDefinitionHandle"/>,
        /// <see cref="TypeReferenceHandle"/>,
        /// <see cref="TypeDefinitionHandle"/>,
        /// <see cref="ParameterHandle"/>,
        /// <see cref="InterfaceImplementationHandle"/>,
        /// <see cref="MemberReferenceHandle"/>,
        /// <see cref="ModuleDefinitionHandle"/>,
        /// <see cref="DeclarativeSecurityAttributeHandle"/>,
        /// <see cref="PropertyDefinitionHandle"/>,
        /// <see cref="EventDefinitionHandle"/>,
        /// <see cref="StandaloneSignatureHandle"/>,
        /// <see cref="ModuleReferenceHandle"/>,
        /// <see cref="TypeSpecificationHandle"/>,
        /// <see cref="AssemblyDefinitionHandle"/>,
        /// <see cref="AssemblyReferenceHandle"/>,
        /// <see cref="AssemblyFileHandle"/>,
        /// <see cref="ExportedTypeHandle"/>,
        /// <see cref="ManifestResourceHandle"/>,
        /// <see cref="GenericParameterHandle"/>,
        /// <see cref="GenericParameterConstraintHandle"/> or
        /// <see cref="MethodSpecificationHandle"/>.
        /// </param>
        /// <exception cref="ArgumentException">Unexpected handle kind.</exception>
        [MethodImpl(Inline)]
        public static uint HasCustomAttribute(MetadataHandleE handle)
            => (handle.RowId << (byte)HasCustomAttributeTag.BitCount) | (uint)CustomAttribute(handle.Kind);

        public static HasCustomAttributeTag CustomAttribute(HandleKind kind)
        {
            switch (kind)
            {
                case HandleKind.MethodDefinition: return HasCustomAttributeTag.MethodDef;
                case HandleKind.FieldDefinition: return HasCustomAttributeTag.Field;
                case HandleKind.TypeReference: return HasCustomAttributeTag.TypeRef;
                case HandleKind.TypeDefinition: return HasCustomAttributeTag.TypeDef;
                case HandleKind.Parameter: return HasCustomAttributeTag.Param;
                case HandleKind.InterfaceImplementation: return HasCustomAttributeTag.InterfaceImpl;
                case HandleKind.MemberReference: return HasCustomAttributeTag.MemberRef;
                case HandleKind.ModuleDefinition: return HasCustomAttributeTag.Module;
                case HandleKind.DeclarativeSecurityAttribute: return HasCustomAttributeTag.DeclSecurity;
                case HandleKind.PropertyDefinition: return HasCustomAttributeTag.Property;
                case HandleKind.EventDefinition: return HasCustomAttributeTag.Event;
                case HandleKind.StandaloneSignature: return HasCustomAttributeTag.StandAloneSig;
                case HandleKind.ModuleReference: return HasCustomAttributeTag.ModuleRef;
                case HandleKind.TypeSpecification: return HasCustomAttributeTag.TypeSpec;
                case HandleKind.AssemblyDefinition: return HasCustomAttributeTag.Assembly;
                case HandleKind.AssemblyReference: return HasCustomAttributeTag.AssemblyRef;
                case HandleKind.AssemblyFile: return HasCustomAttributeTag.File;
                case HandleKind.ExportedType: return HasCustomAttributeTag.ExportedType;
                case HandleKind.ManifestResource: return HasCustomAttributeTag.ManifestResource;
                case HandleKind.GenericParameter: return HasCustomAttributeTag.GenericParam;
                case HandleKind.GenericParameterConstraint: return HasCustomAttributeTag.GenericParamConstraint;
                case HandleKind.MethodSpecification: return HasCustomAttributeTag.MethodSpec;

                default:
                    return 0;
            }
        }

        [Op]
        public static HasCustomDebugInformationTag CustomDebugInformation(HandleKind kind)
        {
            switch (kind)
            {
                case HandleKind.MethodDefinition: return HasCustomDebugInformationTag.MethodDef;
                case HandleKind.FieldDefinition: return HasCustomDebugInformationTag.Field;
                case HandleKind.TypeReference: return HasCustomDebugInformationTag.TypeRef;
                case HandleKind.TypeDefinition: return HasCustomDebugInformationTag.TypeDef;
                case HandleKind.Parameter: return HasCustomDebugInformationTag.Param;
                case HandleKind.InterfaceImplementation: return HasCustomDebugInformationTag.InterfaceImpl;
                case HandleKind.MemberReference: return HasCustomDebugInformationTag.MemberRef;
                case HandleKind.ModuleDefinition: return HasCustomDebugInformationTag.Module;
                case HandleKind.DeclarativeSecurityAttribute: return HasCustomDebugInformationTag.DeclSecurity;
                case HandleKind.PropertyDefinition: return HasCustomDebugInformationTag.Property;
                case HandleKind.EventDefinition: return HasCustomDebugInformationTag.Event;
                case HandleKind.StandaloneSignature: return HasCustomDebugInformationTag.StandAloneSig;
                case HandleKind.ModuleReference: return HasCustomDebugInformationTag.ModuleRef;
                case HandleKind.TypeSpecification: return HasCustomDebugInformationTag.TypeSpec;
                case HandleKind.AssemblyDefinition: return HasCustomDebugInformationTag.Assembly;
                case HandleKind.AssemblyReference: return HasCustomDebugInformationTag.AssemblyRef;
                case HandleKind.AssemblyFile: return HasCustomDebugInformationTag.File;
                case HandleKind.ExportedType: return HasCustomDebugInformationTag.ExportedType;
                case HandleKind.ManifestResource: return HasCustomDebugInformationTag.ManifestResource;
                case HandleKind.GenericParameter: return HasCustomDebugInformationTag.GenericParam;
                case HandleKind.GenericParameterConstraint: return HasCustomDebugInformationTag.GenericParamConstraint;
                case HandleKind.MethodSpecification: return HasCustomDebugInformationTag.MethodSpec;
                case HandleKind.Document: return HasCustomDebugInformationTag.Document;
                case HandleKind.LocalScope: return HasCustomDebugInformationTag.LocalScope;
                case HandleKind.LocalVariable: return HasCustomDebugInformationTag.LocalVariable;
                case HandleKind.LocalConstant: return HasCustomDebugInformationTag.LocalConstant;
                case HandleKind.ImportScope: return HasCustomDebugInformationTag.ImportScope;

                default:
                    return 0;
            }
        }

    }

}