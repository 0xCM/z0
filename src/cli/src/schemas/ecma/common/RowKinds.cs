//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;

    using I = TableIndex;

    /// <summary>
    /// Defines a set of types that projects each <see cref='I'/> literal into the type-system
    /// </summary>
    public readonly struct RowKinds
    {
        /// <summary>
        /// Encodes the <see cref='I.IModule' /> literal as a type
        /// </summary>
        public readonly struct Module : IRowKind<Module>
        {
            public I Index => I.Module;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeRef' /> literal as a type
        /// </summary>
        public readonly struct TypeRef : IRowKind<TypeRef>
        {
            public I Index => I.TypeRef;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeDef' /> literal as a type
        /// </summary>
        public readonly struct TypeDef : IRowKind<TypeDef>
        {
            public I Index => I.TypeDef;
        }

        /// <summary>
        /// Encodes the <see cref='I.FieldPtr' /> literal as a type
        /// </summary>
        public readonly struct FieldPtr : IRowKind<FieldPtr>
        {
            public I Index => I.FieldPtr;
        }

        /// <summary>
        /// Encodes the <see cref='I.Field' /> literal as a type
        /// </summary>
        public readonly struct Field : IRowKind<Field>
        {
            public I Index => I.Field;
        }

        public readonly struct MethodPtr : IRowKind<MethodPtr>
        {
            public I Index => I.MethodPtr;
        }

        public readonly struct MethodDef : IRowKind<MethodDef>
        {
            public I Index => I.MethodDef;
        }

        public readonly struct ParamPtr : IRowKind<ParamPtr>
        {
            public I Index => I.ParamPtr;
        }

        public readonly struct Param : IRowKind<Param>
        {
            public I Index => I.Param;
        }

        public readonly struct InterfaceImpl : IRowKind<InterfaceImpl>
        {
            public I Index => I.InterfaceImpl;
        }

        public readonly struct MemberRef : IRowKind<MemberRef>
        {
            public I Index => I.MemberRef;
        }

        public readonly struct Constant : IRowKind<Constant>
        {
            public I Index => I.Constant;
        }

        public readonly struct CustomAttribute : IRowKind<CustomAttribute>
        {
            public I Index => I.CustomAttribute;
        }

        public readonly struct FieldMarshal : IRowKind<FieldMarshal>
        {
            public I Index => I.FieldMarshal;
        }

        public readonly struct DeclSecurity : IRowKind<DeclSecurity>
        {
            public I Index => I.DeclSecurity;
        }

        public readonly struct ClassLayout : IRowKind<ClassLayout>
        {
            public I Index => I.ClassLayout;
        }

        public readonly struct FieldLayout : IRowKind<FieldLayout>
        {
            public I Index => I.FieldLayout;
        }

        public readonly struct StandAloneSig : IRowKind<StandAloneSig>
        {
            public I Index => I.StandAloneSig;
        }

        public readonly struct EventMap : IRowKind<EventMap>
        {
            public I Index => I.EventMap;
        }

        public readonly struct EventPtr : IRowKind<EventPtr>
        {
            public I Index => I.EventPtr;
        }

        public readonly struct Event : IRowKind<Event>
        {
            public I Index => I.Event;
        }

        public readonly struct PropertyMap : IRowKind<PropertyMap>
        {
            public I Index => I.PropertyMap;
        }

        public readonly struct PropertyPtr : IRowKind<PropertyPtr>
        {
            public I Index => I.PropertyPtr;
        }

        public readonly struct Property : IRowKind<Property>
        {
            public I Index => I.Property;
        }

        public readonly struct MethodSemantics : IRowKind<MethodSemantics>
        {
            public I Index => I.MethodSemantics;
        }

        public readonly struct MethodImpl : IRowKind<MethodImpl>
        {
            public I Index => I.MethodImpl;
        }

        public readonly struct ModuleRef : IRowKind<ModuleRef>
        {
            public I Index => I.ModuleRef;
        }

        public readonly struct TypeSpec : IRowKind<TypeSpec>
        {
            public I Index => I.TypeSpec;
        }

        public readonly struct FieldRva : IRowKind<FieldRva>
        {
            public I Index => I.FieldRva;
        }

        public readonly struct EncLog : IRowKind<EncLog>
        {
            public I Index => I.EncLog;
        }

        public readonly struct EncMap : IRowKind<EncMap>
        {
            public I Index => I.EncMap;
        }

        public readonly struct Assembly : IRowKind<Assembly>
        {
            public I Index => I.Assembly;
        }

        public readonly struct AssemblyProcessor : IRowKind<AssemblyProcessor>
        {
            public I Index => I.AssemblyProcessor;
        }

        public readonly struct AssemblyOS : IRowKind<AssemblyOS>
        {
            public I Index => I.AssemblyOS;
        }

        public readonly struct AssemblyRef : IRowKind<AssemblyRef>
        {
            public I Index => I.AssemblyRef;
        }

        public readonly struct AssemblyRefProcessor : IRowKind<AssemblyRefProcessor>
        {
            public I Index => I.AssemblyRefProcessor;
        }

        public readonly struct AssemblyRefOS : IRowKind<AssemblyRefOS>
        {
            public I Index => I.AssemblyRefOS;
        }

        public readonly struct File : IRowKind<File>
        {
            public I Index => I.File;
        }

        public readonly struct ExportedType : IRowKind<ExportedType>
        {
            public I Index => I.ExportedType;
        }

        public readonly struct ManifestResource : IRowKind<ManifestResource>
        {
            public I Index => I.ManifestResource;
        }

        public readonly struct NestedClass : IRowKind<NestedClass>
        {
            public I Index => I.NestedClass;
        }

        public readonly struct GenericParam : IRowKind<GenericParam>
        {
            public I Index => I.GenericParam;
        }

        public readonly struct MethodSpec : IRowKind<MethodSpec>
        {
            public I Index => I.MethodSpec;
        }

        public readonly struct GenericParamConstraint : IRowKind<GenericParamConstraint>
        {
            public I Index => I.GenericParamConstraint;
        }

        public readonly struct Document : IRowKind<Document>
        {
            public I Index => I.Document;
        }

        public readonly struct MethodDebugInformation : IRowKind<MethodDebugInformation>
        {
            public I Index => I.MethodDebugInformation;
        }

        public readonly struct LocalScope : IRowKind<LocalScope>
        {
            public I Index => I.LocalScope;
        }

        public readonly struct LocalVariable : IRowKind<LocalVariable>
        {
            public I Index => I.LocalVariable;
        }

        public readonly struct LocalConstant : IRowKind<LocalConstant>
        {
            public I Index => I.LocalConstant;
        }

        public readonly struct ImportScope : IRowKind<ImportScope>
        {
            public I Index => I.ImportScope;
        }

        public readonly struct StateMachineMethod : IRowKind<StateMachineMethod>
        {
            public I Index => I.StateMachineMethod;
        }

        public readonly struct CustomDebugInformation : IRowKind<CustomDebugInformation>
        {
            public I Index => I.CustomDebugInformation;
        }
    }
}