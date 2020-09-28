//-----------------------------------------------------------------------------
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

    using T = Image.Tags;

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
        [MethodImpl(Inline), Op]
        public static uint HasCustomAttribute(MetadataHandleE handle)
            => (handle.RowId << (byte)T.HasCustomAttributeTag.BitCount) | (uint)CustomAttribute(handle.Kind);

        [Op]
        public static T.HasCustomAttributeTag CustomAttribute(HandleKind kind)
        {
            switch (kind)
            {
                case HandleKind.MethodDefinition: return T.HasCustomAttributeTag.MethodDef;
                case HandleKind.FieldDefinition: return T.HasCustomAttributeTag.Field;
                case HandleKind.TypeReference: return T.HasCustomAttributeTag.TypeRef;
                case HandleKind.TypeDefinition: return T.HasCustomAttributeTag.TypeDef;
                case HandleKind.Parameter: return T.HasCustomAttributeTag.Param;
                case HandleKind.InterfaceImplementation: return T.HasCustomAttributeTag.InterfaceImpl;
                case HandleKind.MemberReference: return T.HasCustomAttributeTag.MemberRef;
                case HandleKind.ModuleDefinition: return T.HasCustomAttributeTag.Module;
                case HandleKind.DeclarativeSecurityAttribute: return T.HasCustomAttributeTag.DeclSecurity;
                case HandleKind.PropertyDefinition: return T.HasCustomAttributeTag.Property;
                case HandleKind.EventDefinition: return T.HasCustomAttributeTag.Event;
                case HandleKind.StandaloneSignature: return T.HasCustomAttributeTag.StandAloneSig;
                case HandleKind.ModuleReference: return T.HasCustomAttributeTag.ModuleRef;
                case HandleKind.TypeSpecification: return T.HasCustomAttributeTag.TypeSpec;
                case HandleKind.AssemblyDefinition: return T.HasCustomAttributeTag.Assembly;
                case HandleKind.AssemblyReference: return T.HasCustomAttributeTag.AssemblyRef;
                case HandleKind.AssemblyFile: return T.HasCustomAttributeTag.File;
                case HandleKind.ExportedType: return T.HasCustomAttributeTag.ExportedType;
                case HandleKind.ManifestResource: return T.HasCustomAttributeTag.ManifestResource;
                case HandleKind.GenericParameter: return T.HasCustomAttributeTag.GenericParam;
                case HandleKind.GenericParameterConstraint: return T.HasCustomAttributeTag.GenericParamConstraint;
                case HandleKind.MethodSpecification: return T.HasCustomAttributeTag.MethodSpec;

                default:
                    return 0;
            }
        }

        [Op]
        public static T.HasCustomDebugInformationTag CustomDebugInformation(HandleKind kind)
        {
            switch (kind)
            {
                case HandleKind.MethodDefinition: return T.HasCustomDebugInformationTag.MethodDef;
                case HandleKind.FieldDefinition: return T.HasCustomDebugInformationTag.Field;
                case HandleKind.TypeReference: return T.HasCustomDebugInformationTag.TypeRef;
                case HandleKind.TypeDefinition: return T.HasCustomDebugInformationTag.TypeDef;
                case HandleKind.Parameter: return T.HasCustomDebugInformationTag.Param;
                case HandleKind.InterfaceImplementation: return T.HasCustomDebugInformationTag.InterfaceImpl;
                case HandleKind.MemberReference: return T.HasCustomDebugInformationTag.MemberRef;
                case HandleKind.ModuleDefinition: return T.HasCustomDebugInformationTag.Module;
                case HandleKind.DeclarativeSecurityAttribute: return T.HasCustomDebugInformationTag.DeclSecurity;
                case HandleKind.PropertyDefinition: return T.HasCustomDebugInformationTag.Property;
                case HandleKind.EventDefinition: return T.HasCustomDebugInformationTag.Event;
                case HandleKind.StandaloneSignature: return T.HasCustomDebugInformationTag.StandAloneSig;
                case HandleKind.ModuleReference: return T.HasCustomDebugInformationTag.ModuleRef;
                case HandleKind.TypeSpecification: return T.HasCustomDebugInformationTag.TypeSpec;
                case HandleKind.AssemblyDefinition: return T.HasCustomDebugInformationTag.Assembly;
                case HandleKind.AssemblyReference: return T.HasCustomDebugInformationTag.AssemblyRef;
                case HandleKind.AssemblyFile: return T.HasCustomDebugInformationTag.File;
                case HandleKind.ExportedType: return T.HasCustomDebugInformationTag.ExportedType;
                case HandleKind.ManifestResource: return T.HasCustomDebugInformationTag.ManifestResource;
                case HandleKind.GenericParameter: return T.HasCustomDebugInformationTag.GenericParam;
                case HandleKind.GenericParameterConstraint: return T.HasCustomDebugInformationTag.GenericParamConstraint;
                case HandleKind.MethodSpecification: return T.HasCustomDebugInformationTag.MethodSpec;
                case HandleKind.Document: return T.HasCustomDebugInformationTag.Document;
                case HandleKind.LocalScope: return T.HasCustomDebugInformationTag.LocalScope;
                case HandleKind.LocalVariable: return T.HasCustomDebugInformationTag.LocalVariable;
                case HandleKind.LocalConstant: return T.HasCustomDebugInformationTag.LocalConstant;
                case HandleKind.ImportScope: return T.HasCustomDebugInformationTag.ImportScope;

                default:
                    return 0;
            }
        }
    }
}