//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using I = System.Reflection.Metadata.Ecma335.TableIndex;

    /// <summary>
    /// Defines a set of types that projects each <see cref='I'/> literal into the type-system
    /// </summary>
    public readonly struct CliArtifactKinds
    {
        /// <summary>
        /// Encodes the <see cref='I.IModule' /> literal as a type
        /// </summary>
        public readonly struct Module : ICliArtifactKind<Module>
        {
            public I Index => I.Module;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeRef' /> literal as a type
        /// </summary>
        public readonly struct TypeRef : ICliArtifactKind<TypeRef>
        {
            public I Index => I.TypeRef;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeDef' /> literal as a type
        /// </summary>
        public readonly struct TypeDef : ICliArtifactKind<TypeDef>
        {
            public I Index => I.TypeDef;
        }

        /// <summary>
        /// Encodes the <see cref='I.FieldPtr' /> literal as a type
        /// </summary>
        public readonly struct FieldPtr : ICliArtifactKind<FieldPtr>
        {
            public I Index => I.FieldPtr;
        }

        /// <summary>
        /// Encodes the <see cref='I.Field' /> literal as a type
        /// </summary>
        public readonly struct Field : ICliArtifactKind<Field>
        {
            public I Index => I.Field;
        }

        public readonly struct MethodPtr : ICliArtifactKind<MethodPtr>
        {
            public I Index => I.MethodPtr;
        }

        public readonly struct MethodDef : ICliArtifactKind<MethodDef>
        {
            public I Index => I.MethodDef;
        }

        public readonly struct ParamPtr : ICliArtifactKind<ParamPtr>
        {
            public I Index => I.ParamPtr;
        }

        public readonly struct Param : ICliArtifactKind<Param>
        {
            public I Index => I.Param;
        }

        public readonly struct InterfaceImpl : ICliArtifactKind<InterfaceImpl>
        {
            public I Index => I.InterfaceImpl;
        }

        public readonly struct MemberRef : ICliArtifactKind<MemberRef>
        {
            public I Index => I.MemberRef;
        }

        public readonly struct Constant : ICliArtifactKind<Constant>
        {
            public I Index => I.Constant;
        }

        public readonly struct CustomAttribute : ICliArtifactKind<CustomAttribute>
        {
            public I Index => I.CustomAttribute;
        }

        public readonly struct FieldMarshal : ICliArtifactKind<FieldMarshal>
        {
            public I Index => I.FieldMarshal;
        }

        public readonly struct DeclSecurity : ICliArtifactKind<DeclSecurity>
        {
            public I Index => I.DeclSecurity;
        }

        public readonly struct ClassLayout : ICliArtifactKind<ClassLayout>
        {
            public I Index => I.ClassLayout;
        }

        public readonly struct FieldLayout : ICliArtifactKind<FieldLayout>
        {
            public I Index => I.FieldLayout;
        }

        public readonly struct StandAloneSig : ICliArtifactKind<StandAloneSig>
        {
            public I Index => I.StandAloneSig;
        }

        public readonly struct EventMap : ICliArtifactKind<EventMap>
        {
            public I Index => I.EventMap;
        }

        public readonly struct EventPtr : ICliArtifactKind<EventPtr>
        {
            public I Index => I.EventPtr;
        }

        public readonly struct Event : ICliArtifactKind<Event>
        {
            public I Index => I.Event;
        }

        public readonly struct PropertyMap : ICliArtifactKind<PropertyMap>
        {
            public I Index => I.PropertyMap;
        }

        public readonly struct PropertyPtr : ICliArtifactKind<PropertyPtr>
        {
            public I Index => I.PropertyPtr;
        }

        public readonly struct Property : ICliArtifactKind<Property>
        {
            public I Index => I.Property;
        }

        public readonly struct MethodSemantics : ICliArtifactKind<MethodSemantics>
        {
            public I Index => I.MethodSemantics;
        }

        public readonly struct MethodImpl : ICliArtifactKind<MethodImpl>
        {
            public I Index => I.MethodImpl;
        }

        public readonly struct ModuleRef : ICliArtifactKind<ModuleRef>
        {
            public I Index => I.ModuleRef;
        }

        public readonly struct TypeSpec : ICliArtifactKind<TypeSpec>
        {
            public I Index => I.TypeSpec;
        }

        public readonly struct FieldRva : ICliArtifactKind<FieldRva>
        {
            public I Index => I.FieldRva;
        }

        public readonly struct EncLog : ICliArtifactKind<EncLog>
        {
            public I Index => I.EncLog;
        }

        public readonly struct EncMap : ICliArtifactKind<EncMap>
        {
            public I Index => I.EncMap;
        }

        public readonly struct Assembly : ICliArtifactKind<Assembly>
        {
            public I Index => I.Assembly;
        }

        public readonly struct AssemblyProcessor : ICliArtifactKind<AssemblyProcessor>
        {
            public I Index => I.AssemblyProcessor;
        }

        public readonly struct AssemblyOS : ICliArtifactKind<AssemblyOS>
        {
            public I Index => I.AssemblyOS;
        }

        public readonly struct AssemblyRef : ICliArtifactKind<AssemblyRef>
        {
            public I Index => I.AssemblyRef;
        }

        public readonly struct AssemblyRefProcessor : ICliArtifactKind<AssemblyRefProcessor>
        {
            public I Index => I.AssemblyRefProcessor;
        }

        public readonly struct AssemblyRefOS : ICliArtifactKind<AssemblyRefOS>
        {
            public I Index => I.AssemblyRefOS;
        }

        public readonly struct File : ICliArtifactKind<File>
        {
            public I Index => I.File;
        }

        public readonly struct ExportedType : ICliArtifactKind<ExportedType>
        {
            public I Index => I.ExportedType;
        }

        public readonly struct ManifestResource : ICliArtifactKind<ManifestResource>
        {
            public I Index => I.ManifestResource;
        }

        public readonly struct NestedClass : ICliArtifactKind<NestedClass>
        {
            public I Index => I.NestedClass;
        }

        public readonly struct GenericParam : ICliArtifactKind<GenericParam>
        {
            public I Index => I.GenericParam;
        }

        public readonly struct MethodSpec : ICliArtifactKind<MethodSpec>
        {
            public I Index => I.MethodSpec;
        }

        public readonly struct GenericParamConstraint : ICliArtifactKind<GenericParamConstraint>
        {
            public I Index => I.GenericParamConstraint;
        }

        public readonly struct Document : ICliArtifactKind<Document>
        {
            public I Index => I.Document;
        }

        public readonly struct MethodDebugInformation : ICliArtifactKind<MethodDebugInformation>
        {
            public I Index => I.MethodDebugInformation;
        }

        public readonly struct LocalScope : ICliArtifactKind<LocalScope>
        {
            public I Index => I.LocalScope;
        }

        public readonly struct LocalVariable : ICliArtifactKind<LocalVariable>
        {
            public I Index => I.LocalVariable;
        }

        public readonly struct LocalConstant : ICliArtifactKind<LocalConstant>
        {
            public I Index => I.LocalConstant;
        }

        public readonly struct ImportScope : ICliArtifactKind<ImportScope>
        {
            public I Index => I.ImportScope;
        }

        public readonly struct StateMachineMethod : ICliArtifactKind<StateMachineMethod>
        {
            public I Index => I.StateMachineMethod;
        }

        public readonly struct CustomDebugInformation : ICliArtifactKind<CustomDebugInformation>
        {
            public I Index => I.CustomDebugInformation;
        }
    }
}