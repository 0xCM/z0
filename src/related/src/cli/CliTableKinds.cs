//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using R = CliRecords;

    public readonly struct CliTableKinds
    {
        /// <summary>
        /// 0x00
        /// </summary>
        public readonly struct Module : ICliTableKind<Module,R.ModuleRow>
        {
            public CliTableKind TableKind => CliTableKind.Module;
        }

        /// <summary>
        /// 0x01
        /// </summary>
        public readonly struct TypeRef : ICliTableKind<TypeRef,R.TypeRefRow>
        {
            public CliTableKind TableKind => CliTableKind.TypeRef;
        }


        public readonly struct TypeDef : ICliTableKind<TypeDef,R.TypeDefRow>
        {
            public CliTableKind TableKind => CliTableKind.TypeDef;
        }

        public readonly struct FieldPtr : ICliTableKind<FieldPtr,R.FieldPtrRow>
        {
            public CliTableKind TableKind => CliTableKind.FieldPtr;
        }

        public readonly struct Field : ICliTableKind<Field,R.FieldRow>
        {
            public CliTableKind TableKind => CliTableKind.Field;
        }

        public readonly struct MethodPtr : ICliTableKind<MethodPtr,R.MethodPtrRow>
        {
            public CliTableKind TableKind => CliTableKind.MethodPtr;
        }

        public readonly struct MethodDef : ICliTableKind<MethodDef,R.MethodDefRow>
        {
            public CliTableKind TableKind => CliTableKind.MethodDef;
        }

        // public readonly struct ParamPtr : ICliTableKind<ParamPtr,R.ModuleRow>
        // {
        //     public CliTableKind TableKind => CliTableKind.ParamPtr;
        // }

        public readonly struct Param : ICliTableKind<Param,R.ParamRow>
        {
            public CliTableKind TableKind => CliTableKind.Param;
        }

        public readonly struct InterfaceImpl : ICliTableKind<InterfaceImpl,R.InterfaceImplRow>
        {
            public CliTableKind TableKind => CliTableKind.InterfaceImpl;
        }

        public readonly struct MemberRef : ICliTableKind<MemberRef,R.MemberRefRow>
        {
            public CliTableKind TableKind => CliTableKind.MemberRef;
        }

        public readonly struct Constant : ICliTableKind<Constant,R.ConstantRow>
        {
            public CliTableKind TableKind => CliTableKind.Constant;
        }

        public readonly struct CustomAttribute : ICliTableKind<CustomAttribute,R.CustomAttributeRow>
        {
            public CliTableKind TableKind => CliTableKind.CustomAttribute;
        }

        public readonly struct FieldMarshal : ICliTableKind<FieldMarshal,R.FieldMarshalRow>
        {
            public CliTableKind TableKind => CliTableKind.FieldMarshal;
        }

        public readonly struct DeclSecurity : ICliTableKind<DeclSecurity,R.DeclSecurityRow>
        {
            public CliTableKind TableKind => CliTableKind.DeclSecurity;
        }

        public readonly struct ClassLayout : ICliTableKind<ClassLayout,R.ClassLayoutRow>
        {
            public CliTableKind TableKind => CliTableKind.ClassLayout;
        }

        public readonly struct FieldLayout : ICliTableKind<FieldLayout,R.FieldLayoutRow>
        {
            public CliTableKind TableKind => CliTableKind.ClassLayout;
        }

        public readonly struct StandAloneSig : ICliTableKind<StandAloneSig,R.StandaloneSigRow>
        {
            public CliTableKind TableKind => CliTableKind.StandAloneSig;
        }

        public readonly struct EventMap : ICliTableKind<EventMap,R.EventMapRow>
        {
            public CliTableKind TableKind => CliTableKind.EventMap;
        }

        // public readonly struct EventPtr : ICliTableKind<EventPtr,R.ModuleRow>
        // {
        //     public CliTableKind TableKind => CliTableKind.EventPtr;
        // }

        public readonly struct Event : ICliTableKind<Event,R.EventRow>
        {
            public CliTableKind TableKind => CliTableKind.Event;
        }

        public readonly struct PropertyMap : ICliTableKind<PropertyMap,R.PropertyMapRow>
        {
            public CliTableKind TableKind => CliTableKind.PropertyMap;
        }

        // public readonly struct PropertyPtr : ICliTableKind<PropertyPtr,R.ModuleRow>
        // {
        //     public CliTableKind TableKind => CliTableKind.PropertyPtr;
        // }

        public readonly struct Property : ICliTableKind<Property,R.PropertyRow>
        {
            public CliTableKind TableKind => CliTableKind.Property;
        }

        public readonly struct MethodSemantics : ICliTableKind<MethodSemantics,R.MethodSemanticsRow>
        {
            public CliTableKind TableKind => CliTableKind.MethodSemantics;
        }

        public readonly struct MethodImpl : ICliTableKind<MethodImpl,R.MethodImplRow>
        {
            public CliTableKind TableKind => CliTableKind.MethodImpl;
        }

        public readonly struct ModuleRef : ICliTableKind<ModuleRef,R.ModuleRefRow>
        {
            public CliTableKind TableKind => CliTableKind.ModuleRef;
        }

        public readonly struct TypeSpec : ICliTableKind<TypeSpec,R.TypeSpecRow>
        {
            public CliTableKind TableKind => CliTableKind.TypeSpec;
        }

        public readonly struct ImplMap : ICliTableKind<ImplMap,R.ImplMapRow>
        {
            public CliTableKind TableKind => CliTableKind.ImplMap;
        }

        public readonly struct FieldRva : ICliTableKind<FieldRva,R.FieldRvaRow>
        {
            public CliTableKind TableKind => CliTableKind.FieldRva;
        }

        public readonly struct EncLog : ICliTableKind<EncLog,R.EncLogRow>
        {
            public CliTableKind TableKind => CliTableKind.EncLog;
        }

        public readonly struct EncMap : ICliTableKind<EncMap,R.EncMapRow>
        {
            public CliTableKind TableKind => CliTableKind.EncMap;
        }

        public readonly struct Assembly : ICliTableKind<Assembly,R.AssemblyRow>
        {
            public CliTableKind TableKind => CliTableKind.Assembly;
        }

        public readonly struct AssemblyProcessor : ICliTableKind<AssemblyProcessor,R.AssemblyProcessorRow>
        {
            public CliTableKind TableKind => CliTableKind.AssemblyProcessor;
        }

        public readonly struct AssemblyOS : ICliTableKind<AssemblyOS,R.AssemblyOSRow>
        {
            public CliTableKind TableKind => CliTableKind.AssemblyOS;
        }

        public readonly struct AssemblyRef : ICliTableKind<AssemblyRef,R.AssemblyRefRow>
        {
            public CliTableKind TableKind => CliTableKind.AssemblyRef;
        }

        // public readonly struct AssemblyRefProcessor : ICliTableKind<AssemblyRefProcessor,R.ModuleRow>
        // {
        //     public CliTableKind TableKind => CliTableKind.AssemblyRefProcessor;
        // }


        public readonly struct File : ICliTableKind<File,R.FileRow>
        {
            public CliTableKind TableKind => CliTableKind.File;
        }

        public readonly struct ExportedType : ICliTableKind<ExportedType,R.ExportedTypeRow>
        {
            public CliTableKind TableKind => CliTableKind.ExportedType;
        }

        public readonly struct ManifestResource : ICliTableKind<ManifestResource,R.ManifestResourceRow>
        {
            public CliTableKind TableKind => CliTableKind.ManifestResource;
        }

        public readonly struct NestedClass : ICliTableKind<NestedClass,R.NestedClassRow>
        {
            public CliTableKind TableKind => CliTableKind.NestedClass;
        }

        public readonly struct GenericParam : ICliTableKind<GenericParam,R.GenericParamRow>
        {
            public CliTableKind TableKind => CliTableKind.GenericParam;
        }

        public readonly struct MethodSpec : ICliTableKind<MethodSpec,R.MethodSpecRow>
        {
            public CliTableKind TableKind => CliTableKind.MethodSpec;
        }

        public readonly struct GenericParamConstraint : ICliTableKind<GenericParamConstraint,R.GenericParamConstraintRow>
        {
            public CliTableKind TableKind => CliTableKind.GenericParamConstraint;
        }

        public readonly struct Document : ICliTableKind<Document,R.DocumentRow>
        {
            public CliTableKind TableKind => CliTableKind.Document;
        }

        public readonly struct MethodDebugInformation : ICliTableKind<MethodDebugInformation,R.MethodDebugInformationRow>
        {
            public CliTableKind TableKind => CliTableKind.MethodDebugInformation;
        }


        public readonly struct LocalScope : ICliTableKind<LocalScope,R.LocalScopeRow>
        {
            public CliTableKind TableKind => CliTableKind.LocalScope;
        }

        public readonly struct LocalVariable : ICliTableKind<LocalVariable,R.LocalVariableRow>
        {
            public CliTableKind TableKind => CliTableKind.LocalVariable;
        }

        public readonly struct LocalConstant : ICliTableKind<LocalConstant,R.LocalConstantRow>
        {
            public CliTableKind TableKind => CliTableKind.LocalConstant;
        }

        public readonly struct ImportScope : ICliTableKind<ImportScope,R.ImportScopeRow>
        {
            public CliTableKind TableKind => CliTableKind.ImportScope;
        }

        public readonly struct StateMachineMethod : ICliTableKind<StateMachineMethod,R.StateMachineMethodRow>
        {
            public CliTableKind TableKind => CliTableKind.StateMachineMethod;
        }

        public readonly struct CustomDebugInformation : ICliTableKind<CustomDebugInformation,R.CustomDebugInformationRow>
        {
            public CliTableKind TableKind => CliTableKind.CustomDebugInformation;
        }
     }
}