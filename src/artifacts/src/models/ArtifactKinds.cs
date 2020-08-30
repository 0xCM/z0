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
    public readonly struct ArtifactKinds
    {
        /// <summary>
        /// Encodes the <see cref='I.IModule' /> literal as a type
        /// </summary>
        public readonly struct Module : IArtifactKind<Module>
        {
            public I Index => I.Module;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeRef' /> literal as a type
        /// </summary>
        public readonly struct TypeRef : IArtifactKind<TypeRef>
        {
            public I Index => I.TypeRef;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeDef' /> literal as a type
        /// </summary>
        public readonly struct TypeDef : IArtifactKind<TypeDef>
        {
            public I Index => I.TypeDef;
        }

        /// <summary>
        /// Encodes the <see cref='I.FieldPtr' /> literal as a type
        /// </summary>
        public readonly struct FieldPtr : IArtifactKind<FieldPtr>
        {
            public I Index => I.FieldPtr;
        }

        /// <summary>
        /// Encodes the <see cref='I.Field' /> literal as a type
        /// </summary>
        public readonly struct Field : IArtifactKind<Field>
        {
            public I Index => I.Field;
        }

        public readonly struct MethodPtr : IArtifactKind<MethodPtr>
        {
            public I Index => I.MethodPtr;
        }

        public readonly struct MethodDef : IArtifactKind<MethodDef>
        {
            public I Index => I.MethodDef;
        }

        public readonly struct ParamPtr : IArtifactKind<ParamPtr>
        {
            public I Index => I.ParamPtr;
        }

        public readonly struct Param : IArtifactKind<Param>
        {
            public I Index => I.Param;
        }

        public readonly struct InterfaceImpl : IArtifactKind<InterfaceImpl>
        {
            public I Index => I.InterfaceImpl;
        }

        public readonly struct MemberRef : IArtifactKind<MemberRef>
        {
            public I Index => I.MemberRef;
        }

        public readonly struct Constant : IArtifactKind<Constant>
        {
            public I Index => I.Constant;
        }

        public readonly struct CustomAttribute : IArtifactKind<CustomAttribute>
        {
            public I Index => I.CustomAttribute;
        }

        public readonly struct FieldMarshal : IArtifactKind<FieldMarshal>
        {
            public I Index => I.FieldMarshal;
        }

        public readonly struct DeclSecurity : IArtifactKind<DeclSecurity>
        {
            public I Index => I.DeclSecurity;
        }

        public readonly struct ClassLayout : IArtifactKind<ClassLayout>
        {
            public I Index => I.ClassLayout;
        }

        public readonly struct FieldLayout : IArtifactKind<FieldLayout>
        {
            public I Index => I.FieldLayout;
        }

        public readonly struct StandAloneSig : IArtifactKind<StandAloneSig>
        {
            public I Index => I.StandAloneSig;
        }

        public readonly struct EventMap : IArtifactKind<EventMap>
        {
            public I Index => I.EventMap;
        }

        public readonly struct EventPtr : IArtifactKind<EventPtr>
        {
            public I Index => I.EventPtr;
        }

        public readonly struct Event : IArtifactKind<Event>
        {
            public I Index => I.Event;
        }

        public readonly struct PropertyMap : IArtifactKind<PropertyMap>
        {
            public I Index => I.PropertyMap;
        }

        public readonly struct PropertyPtr : IArtifactKind<PropertyPtr>
        {
            public I Index => I.PropertyPtr;
        }

        public readonly struct Property : IArtifactKind<Property>
        {
            public I Index => I.Property;
        }

        public readonly struct MethodSemantics : IArtifactKind<MethodSemantics>
        {
            public I Index => I.MethodSemantics;
        }

        public readonly struct MethodImpl : IArtifactKind<MethodImpl>
        {
            public I Index => I.MethodImpl;
        }

        public readonly struct ModuleRef : IArtifactKind<ModuleRef>
        {
            public I Index => I.ModuleRef;
        }

        public readonly struct TypeSpec : IArtifactKind<TypeSpec>
        {
            public I Index => I.TypeSpec;
        }

        public readonly struct FieldRva : IArtifactKind<FieldRva>
        {
            public I Index => I.FieldRva;
        }

        public readonly struct EncLog : IArtifactKind<EncLog>
        {
            public I Index => I.EncLog;
        }

        public readonly struct EncMap : IArtifactKind<EncMap>
        {
            public I Index => I.EncMap;
        }

        public readonly struct Assembly : IArtifactKind<Assembly>
        {
            public I Index => I.Assembly;
        }

        public readonly struct AssemblyProcessor : IArtifactKind<AssemblyProcessor>
        {
            public I Index => I.AssemblyProcessor;
        }

        public readonly struct AssemblyOS : IArtifactKind<AssemblyOS>
        {
            public I Index => I.AssemblyOS;
        }

        public readonly struct AssemblyRef : IArtifactKind<AssemblyRef>
        {
            public I Index => I.AssemblyRef;
        }

        public readonly struct AssemblyRefProcessor : IArtifactKind<AssemblyRefProcessor>
        {
            public I Index => I.AssemblyRefProcessor;
        }

        public readonly struct AssemblyRefOS : IArtifactKind<AssemblyRefOS>
        {
            public I Index => I.AssemblyRefOS;
        }

        public readonly struct File : IArtifactKind<File>
        {
            public I Index => I.File;
        }

        public readonly struct ExportedType : IArtifactKind<ExportedType>
        {
            public I Index => I.ExportedType;
        }

        public readonly struct ManifestResource : IArtifactKind<ManifestResource>
        {
            public I Index => I.ManifestResource;
        }

        public readonly struct NestedClass : IArtifactKind<NestedClass>
        {
            public I Index => I.NestedClass;
        }

        public readonly struct GenericParam : IArtifactKind<GenericParam>
        {
            public I Index => I.GenericParam;
        }

        public readonly struct MethodSpec : IArtifactKind<MethodSpec>
        {
            public I Index => I.MethodSpec;
        }

        public readonly struct GenericParamConstraint : IArtifactKind<GenericParamConstraint>
        {
            public I Index => I.GenericParamConstraint;
        }

        public readonly struct Document : IArtifactKind<Document>
        {
            public I Index => I.Document;
        }

        public readonly struct MethodDebugInformation : IArtifactKind<MethodDebugInformation>
        {
            public I Index => I.MethodDebugInformation;
        }

        public readonly struct LocalScope : IArtifactKind<LocalScope>
        {
            public I Index => I.LocalScope;
        }

        public readonly struct LocalVariable : IArtifactKind<LocalVariable>
        {
            public I Index => I.LocalVariable;
        }

        public readonly struct LocalConstant : IArtifactKind<LocalConstant>
        {
            public I Index => I.LocalConstant;
        }

        public readonly struct ImportScope : IArtifactKind<ImportScope>
        {
            public I Index => I.ImportScope;
        }

        public readonly struct StateMachineMethod : IArtifactKind<StateMachineMethod>
        {
            public I Index => I.StateMachineMethod;
        }

        public readonly struct CustomDebugInformation : IArtifactKind<CustomDebugInformation>
        {
            public I Index => I.CustomDebugInformation;
        }
    }
}