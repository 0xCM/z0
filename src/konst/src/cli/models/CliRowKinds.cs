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
    public readonly struct CliRowKinds
    {
        /// <summary>
        /// Encodes the <see cref='I.IModule' /> literal as a type
        /// </summary>
        public readonly struct Module : ICliRowKind<Module>
        {
            public I Index => I.Module;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeRef' /> literal as a type
        /// </summary>
        public readonly struct TypeRef : ICliRowKind<TypeRef>
        {
            public I Index => I.TypeRef;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeDef' /> literal as a type
        /// </summary>
        public readonly struct TypeDef : ICliRowKind<TypeDef>
        {
            public I Index => I.TypeDef;
        }

        /// <summary>
        /// Encodes the <see cref='I.FieldPtr' /> literal as a type
        /// </summary>
        public readonly struct FieldPtr : ICliRowKind<FieldPtr>
        {
            public I Index => I.FieldPtr;
        }

        /// <summary>
        /// Encodes the <see cref='I.Field' /> literal as a type
        /// </summary>
        public readonly struct Field : ICliRowKind<Field>
        {
            public I Index => I.Field;
        }

        public readonly struct MethodPtr : ICliRowKind<MethodPtr>
        {
            public I Index => I.MethodPtr;
        }

        public readonly struct MethodDef : ICliRowKind<MethodDef>
        {
            public I Index => I.MethodDef;
        }

        public readonly struct ParamPtr : ICliRowKind<ParamPtr>
        {
            public I Index => I.ParamPtr;
        }

        public readonly struct Param : ICliRowKind<Param>
        {
            public I Index => I.Param;
        }

        public readonly struct InterfaceImpl : ICliRowKind<InterfaceImpl>
        {
            public I Index => I.InterfaceImpl;
        }

        public readonly struct MemberRef : ICliRowKind<MemberRef>
        {
            public I Index => I.MemberRef;
        }

        public readonly struct Constant : ICliRowKind<Constant>
        {
            public I Index => I.Constant;
        }

        public readonly struct CustomAttribute : ICliRowKind<CustomAttribute>
        {
            public I Index => I.CustomAttribute;
        }

        public readonly struct FieldMarshal : ICliRowKind<FieldMarshal>
        {
            public I Index => I.FieldMarshal;
        }

        public readonly struct DeclSecurity : ICliRowKind<DeclSecurity>
        {
            public I Index => I.DeclSecurity;
        }

        public readonly struct ClassLayout : ICliRowKind<ClassLayout>
        {
            public I Index => I.ClassLayout;
        }

        public readonly struct FieldLayout : ICliRowKind<FieldLayout>
        {
            public I Index => I.FieldLayout;
        }

        public readonly struct StandAloneSig : ICliRowKind<StandAloneSig>
        {
            public I Index => I.StandAloneSig;
        }

        public readonly struct EventMap : ICliRowKind<EventMap>
        {
            public I Index => I.EventMap;
        }

        public readonly struct EventPtr : ICliRowKind<EventPtr>
        {
            public I Index => I.EventPtr;
        }

        public readonly struct Event : ICliRowKind<Event>
        {
            public I Index => I.Event;
        }

        public readonly struct PropertyMap : ICliRowKind<PropertyMap>
        {
            public I Index => I.PropertyMap;
        }

        public readonly struct PropertyPtr : ICliRowKind<PropertyPtr>
        {
            public I Index => I.PropertyPtr;
        }

        public readonly struct Property : ICliRowKind<Property>
        {
            public I Index => I.Property;
        }

        public readonly struct MethodSemantics : ICliRowKind<MethodSemantics>
        {
            public I Index => I.MethodSemantics;
        }

        public readonly struct MethodImpl : ICliRowKind<MethodImpl>
        {
            public I Index => I.MethodImpl;
        }

        public readonly struct ModuleRef : ICliRowKind<ModuleRef>
        {
            public I Index => I.ModuleRef;
        }

        public readonly struct TypeSpec : ICliRowKind<TypeSpec>
        {
            public I Index => I.TypeSpec;
        }

        public readonly struct FieldRva : ICliRowKind<FieldRva>
        {
            public I Index => I.FieldRva;
        }

        public readonly struct EncLog : ICliRowKind<EncLog>
        {
            public I Index => I.EncLog;
        }

        public readonly struct EncMap : ICliRowKind<EncMap>
        {
            public I Index => I.EncMap;
        }

        public readonly struct Assembly : ICliRowKind<Assembly>
        {
            public I Index => I.Assembly;
        }

        public readonly struct AssemblyProcessor : ICliRowKind<AssemblyProcessor>
        {
            public I Index => I.AssemblyProcessor;
        }

        public readonly struct AssemblyOS : ICliRowKind<AssemblyOS>
        {
            public I Index => I.AssemblyOS;
        }

        public readonly struct AssemblyRef : ICliRowKind<AssemblyRef>
        {
            public I Index => I.AssemblyRef;
        }

        public readonly struct AssemblyRefProcessor : ICliRowKind<AssemblyRefProcessor>
        {
            public I Index => I.AssemblyRefProcessor;
        }

        public readonly struct AssemblyRefOS : ICliRowKind<AssemblyRefOS>
        {
            public I Index => I.AssemblyRefOS;
        }

        public readonly struct File : ICliRowKind<File>
        {
            public I Index => I.File;
        }

        public readonly struct ExportedType : ICliRowKind<ExportedType>
        {
            public I Index => I.ExportedType;
        }

        public readonly struct ManifestResource : ICliRowKind<ManifestResource>
        {
            public I Index => I.ManifestResource;
        }

        public readonly struct NestedClass : ICliRowKind<NestedClass>
        {
            public I Index => I.NestedClass;
        }

        public readonly struct GenericParam : ICliRowKind<GenericParam>
        {
            public I Index => I.GenericParam;
        }

        public readonly struct MethodSpec : ICliRowKind<MethodSpec>
        {
            public I Index => I.MethodSpec;
        }

        public readonly struct GenericParamConstraint : ICliRowKind<GenericParamConstraint>
        {
            public I Index => I.GenericParamConstraint;
        }

        public readonly struct Document : ICliRowKind<Document>
        {
            public I Index => I.Document;
        }

        public readonly struct MethodDebugInformation : ICliRowKind<MethodDebugInformation>
        {
            public I Index => I.MethodDebugInformation;
        }

        public readonly struct LocalScope : ICliRowKind<LocalScope>
        {
            public I Index => I.LocalScope;
        }

        public readonly struct LocalVariable : ICliRowKind<LocalVariable>
        {
            public I Index => I.LocalVariable;
        }

        public readonly struct LocalConstant : ICliRowKind<LocalConstant>
        {
            public I Index => I.LocalConstant;
        }

        public readonly struct ImportScope : ICliRowKind<ImportScope>
        {
            public I Index => I.ImportScope;
        }

        public readonly struct StateMachineMethod : ICliRowKind<StateMachineMethod>
        {
            public I Index => I.StateMachineMethod;
        }

        public readonly struct CustomDebugInformation : ICliRowKind<CustomDebugInformation>
        {
            public I Index => I.CustomDebugInformation;
        }
    }
}