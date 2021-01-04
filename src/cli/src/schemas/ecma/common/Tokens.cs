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
    public readonly struct Tokens
    {
        /// <summary>
        /// Encodes the <see cref='I.IModule' /> literal as a type
        /// </summary>
        public readonly struct Module : IToken<Module>
        {
            readonly uint Data;

            public Token<Module> Value => Data;

            public I Index => I.Module;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeRef' /> literal as a type
        /// </summary>
        public readonly struct TypeRef : IToken<TypeRef>
        {
            readonly uint Data;

            public Token<TypeRef> Value => Data;

            public I Index => I.TypeRef;
        }

        /// <summary>
        /// Encodes the <see cref='I.TypeDef' /> literal as a type
        /// </summary>
        public readonly struct TypeDef : IToken<TypeDef>
        {
            readonly uint Data;

            public Token<TypeDef> Value => Data;

            public I Index => I.TypeDef;
        }

        /// <summary>
        /// Encodes the <see cref='I.FieldPtr' /> literal as a type
        /// </summary>
        public readonly struct FieldPtr : IToken<FieldPtr>
        {
            readonly uint Data;

            public Token<FieldPtr> Value => Data;

            public I Index => I.FieldPtr;
        }

        /// <summary>
        /// Encodes the <see cref='I.Field' /> literal as a type
        /// </summary>
        public readonly struct Field : IToken<Field>
        {
            readonly uint Data;

            public Token<Field> Value => Data;

            public I Index => I.Field;
        }

        public readonly struct MethodPtr : IToken<MethodPtr>
        {
            readonly uint Data;

            public Token<MethodPtr> Value => Data;

            public I Index => I.MethodPtr;
        }

        public readonly struct MethodDef : IToken<MethodDef>
        {
            readonly uint Data;

            public Token<MethodDef> Value => Data;

            public I Index => I.MethodDef;

        }

        public readonly struct ParamPtr : IToken<ParamPtr>
        {
            readonly uint Data;

            public Token<ParamPtr> Value => Data;

            public I Index => I.ParamPtr;
        }

        public readonly struct Param : IToken<Param>
        {
            readonly uint Data;

            public Token<Param> Value => Data;

            public I Index => I.Param;
        }

        public readonly struct InterfaceImpl : IToken<InterfaceImpl>
        {
            readonly uint Data;

            public Token<InterfaceImpl> Value => Data;

            public I Index => I.InterfaceImpl;
        }

        public readonly struct MemberRef : IToken<MemberRef>
        {
            readonly uint Data;

            public Token<MemberRef> Value => Data;

            public I Index => I.MemberRef;
        }

        public readonly struct Constant : IToken<Constant>
        {
            readonly uint Data;

            public Token<Constant> Value => Data;

            public I Index => I.Constant;
        }

        public readonly struct CustomAttribute : IToken<CustomAttribute>
        {
            readonly uint Data;

            public Token<CustomAttribute> Value => Data;

            public I Index => I.CustomAttribute;
        }

        public readonly struct FieldMarshal : IToken<FieldMarshal>
        {
            readonly uint Data;

            public Token<FieldMarshal> Value => Data;

            public I Index => I.FieldMarshal;
        }

        public readonly struct DeclSecurity : IToken<DeclSecurity>
        {
            readonly uint Data;

            public Token<DeclSecurity> Value => Data;

            public I Index => I.DeclSecurity;
        }

        public readonly struct ClassLayout : IToken<ClassLayout>
        {
            readonly uint Data;

            public Token<ClassLayout> Value => Data;

            public I Index => I.ClassLayout;
        }

        public readonly struct FieldLayout : IToken<FieldLayout>
        {
            readonly uint Data;

            public Token<FieldLayout> Value => Data;

            public I Index => I.FieldLayout;
        }

        public readonly struct StandAloneSig : IToken<StandAloneSig>
        {
            public I Index => I.StandAloneSig;
        }

        public readonly struct EventMap : IToken<EventMap>
        {
            public I Index => I.EventMap;
        }

        public readonly struct EventPtr : IToken<EventPtr>
        {
            public I Index => I.EventPtr;
        }

        public readonly struct Event : IToken<Event>
        {
            public I Index => I.Event;
        }

        public readonly struct PropertyMap : IToken<PropertyMap>
        {
            public I Index => I.PropertyMap;
        }

        public readonly struct PropertyPtr : IToken<PropertyPtr>
        {
            public I Index => I.PropertyPtr;
        }

        public readonly struct Property : IToken<Property>
        {
            public I Index => I.Property;
        }

        public readonly struct MethodSemantics : IToken<MethodSemantics>
        {
            public I Index => I.MethodSemantics;
        }

        public readonly struct MethodImpl : IToken<MethodImpl>
        {
            public I Index => I.MethodImpl;
        }

        public readonly struct ModuleRef : IToken<ModuleRef>
        {
            public I Index => I.ModuleRef;
        }

        public readonly struct TypeSpec : IToken<TypeSpec>
        {
            public I Index => I.TypeSpec;
        }

        public readonly struct FieldRva : IToken<FieldRva>
        {
            public I Index => I.FieldRva;
        }

        public readonly struct EncLog : IToken<EncLog>
        {
            public I Index => I.EncLog;
        }

        public readonly struct EncMap : IToken<EncMap>
        {
            public I Index => I.EncMap;
        }

        public readonly struct Assembly : IToken<Assembly>
        {
            public I Index => I.Assembly;
        }

        public readonly struct AssemblyProcessor : IToken<AssemblyProcessor>
        {
            public I Index => I.AssemblyProcessor;
        }

        public readonly struct AssemblyOS : IToken<AssemblyOS>
        {
            public I Index => I.AssemblyOS;
        }

        public readonly struct AssemblyRef : IToken<AssemblyRef>
        {
            public I Index => I.AssemblyRef;
        }

        public readonly struct AssemblyRefProcessor : IToken<AssemblyRefProcessor>
        {
            public I Index => I.AssemblyRefProcessor;
        }

        public readonly struct AssemblyRefOS : IToken<AssemblyRefOS>
        {
            public I Index => I.AssemblyRefOS;
        }

        public readonly struct File : IToken<File>
        {
            public I Index => I.File;
        }

        public readonly struct ExportedType : IToken<ExportedType>
        {
            public I Index => I.ExportedType;
        }

        public readonly struct ManifestResource : IToken<ManifestResource>
        {
            public I Index => I.ManifestResource;
        }

        public readonly struct NestedClass : IToken<NestedClass>
        {
            public I Index => I.NestedClass;
        }

        public readonly struct GenericParam : IToken<GenericParam>
        {
            public I Index => I.GenericParam;
        }

        public readonly struct MethodSpec : IToken<MethodSpec>
        {
            public I Index => I.MethodSpec;
        }

        public readonly struct GenericParamConstraint : IToken<GenericParamConstraint>
        {
            public I Index => I.GenericParamConstraint;
        }

        public readonly struct Document : IToken<Document>
        {
            public I Index => I.Document;
        }

        public readonly struct MethodDebugInformation : IToken<MethodDebugInformation>
        {
            public I Index => I.MethodDebugInformation;
        }

        public readonly struct LocalScope : IToken<LocalScope>
        {
            public I Index => I.LocalScope;
        }

        public readonly struct LocalVariable : IToken<LocalVariable>
        {
            public I Index => I.LocalVariable;
        }

        public readonly struct LocalConstant : IToken<LocalConstant>
        {
            public I Index => I.LocalConstant;
        }

        public readonly struct ImportScope : IToken<ImportScope>
        {
            public I Index => I.ImportScope;
        }

        public readonly struct StateMachineMethod : IToken<StateMachineMethod>
        {

            public I Index => I.StateMachineMethod;
        }

        public readonly struct CustomDebugInformation : IToken<CustomDebugInformation>
        {
            public I Index => I.CustomDebugInformation;
        }
    }
}