//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static memory;
    using static ImageRecords;

    using K = CliTableKind;

    partial struct Cli
    {
        [MethodImpl(Inline)]
        internal static RowKey key<T>(K kind, T handle)
            where T : unmanaged
                => (kind, uint32(handle));

        [MethodImpl(Inline), Op]
        public static RowKey key(MethodDefinitionHandle src)
            => (K.MethodDef, uint32(src));

        [Op]
        public static RowKeys keys(AssemblyFileHandleCollection src)
            => (src.Array().Select(handle => key(K.File, handle)), K.File);

        [Op]
        public static RowKeys keys(AssemblyReferenceHandleCollection src)
            => (src.Array().Select(handle => key(K.AssemblyRef, handle)), K.CustomAttribute);

        [Op]
        public static RowKeys keys(CustomAttributeHandleCollection src)
            => (src.Array().Select(handle => key(K.CustomAttribute, handle)), K.CustomAttribute);

        [Op]
        public static RowKeys keys(CustomDebugInformationHandleCollection src)
            => (src.Array().Select(handle => key(K.CustomDebugInformation, handle)), K.CustomDebugInformation);

        [Op]
        public static RowKeys keys(DeclarativeSecurityAttributeHandleCollection src)
            => (src.Array().Select(handle => key(K.DeclSecurity, handle)), K.DeclSecurity);

        [Op]
        public static RowKeys keys(DocumentHandleCollection src)
            => (src.Array().Select(handle => key(K.Document, handle)), K.Document);

        [Op]
        public static RowKeys keys(ExportedTypeHandleCollection src)
            => (src.Map(handle => key(K.ExportedType, handle)), K.ExportedType);

        [Op]
        public static RowKeys keys(EventDefinitionHandleCollection src)
            => (src.Map(handle => key(K.Event, handle)), K.Event);

        [Op]
        public static RowKeys keys(FieldDefinitionHandleCollection src)
            => (src.Map(handle => key(K.Field, handle)), K.Field);

        [Op]
        public static RowKeys keys(ImportScopeCollection src)
            => (src.Map(handle => key(K.ImportScope, handle)), K.ImportScope);

        [Op]
        public static RowKeys keys(ParameterHandleCollection src)
            => (src.Map(handle => key(K.Param, handle)), K.ImportScope);

        [Op]
        public static RowKeys keys(GenericParameterHandleCollection src)
            => (src.Map(handle => key(K.GenericParam, handle)), K.ImportScope);

        [Op]
        public static RowKeys keys(GenericParameterConstraintHandleCollection src)
            => (src.Map(handle => key(K.GenericParamConstraint, handle)), K.ImportScope);

        [Op]
        public static RowKeys keys(LocalScopeHandleCollection src)
            => (src.Map(handle => key(K.LocalScope, handle)), K.LocalScope);

        [Op]
        public static RowKeys keys(LocalVariableHandleCollection src)
            => (src.Map(handle => key(K.LocalVariable, handle)), K.LocalVariable);

        [Op]
        public static RowKeys keys(LocalConstantHandleCollection src)
            => (src.Map(handle => key(K.LocalConstant, handle)), K.LocalConstant);

        [Op]
        public static RowKeys keys(MemberReferenceHandleCollection src)
            => (src.Map(handle => key(K.MemberRef, handle)), K.MemberRef);

        [Op]
        public static RowKeys keys(ManifestResourceHandleCollection src)
            => (src.Map(handle => key(K.ManifestResource, handle)), K.ManifestResource);

        [Op]
        public static RowKeys keys(MethodDefinitionHandleCollection src)
            => (src.Map(handle => key(K.MethodDef, handle)), K.MethodDef);

        [Op]
        public static RowKeys keys(PropertyDefinitionHandleCollection src)
            => (src.Map(handle => key(K.Property, handle)), K.Property);

        [Op]
        public static RowKeys keys(MethodDebugInformationHandleCollection src)
            => (src.Map(handle => key(K.MethodDebugInformation, handle)), K.MethodDebugInformation);

        [Op]
        public static RowKeys keys(TypeDefinitionHandleCollection src)
            => (src.Map(handle => key(K.TypeDef, handle)), K.TypeDef);

        [Op]
        public static RowKeys keys(TypeReferenceHandleCollection src)
            => (src.Map(handle => key(K.TypeRef, handle)), K.TypeRef);
    }
}