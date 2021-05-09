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

    using Kinds = CliTableKinds;

    using static CliTableKinds;

    partial struct Cli
    {
        [MethodImpl(Inline)]
        internal static CliRowKey key<T>(CliTableKind kind, T handle)
            where T : unmanaged
                => (kind, uint32(handle));

        [MethodImpl(Inline)]
        internal static CliRowKey<K> key2<K,T>(T handle, K k = default)
            where K : unmanaged, ICliTableKind<K>
            where T : unmanaged
                => uint32(handle);

        [MethodImpl(Inline)]
        internal static CliRowKeys<K> keys<K,T>(T[] handles, K k = default)
            where T : unmanaged
            where K : unmanaged, ICliTableKind<K>
        {
            var count = handles.Length;
            var src = @readonly(handles);
            var buffer = alloc<CliRowKey<K>>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = key2<K,T>(skip(src,i));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static CliRowKey<MethodDef> key(MethodDefinitionHandle src)
            => key2(src,default(MethodDef));

        [Op]
        public static CliRowKeys<File> keys(AssemblyFileHandleCollection src)
            => keys(src.Array(), default(File));

        [Op]
        public static CliRowKeys<AssemblyRef> keys(AssemblyReferenceHandleCollection src)
            => keys(src.Array(), default(AssemblyRef));

        [Op]
        public static CliRowKeys<Kinds.CustomAttribute> keys(CustomAttributeHandleCollection src)
            => keys(src.Array(), default(Kinds.CustomAttribute));

        [Op]
        public static CliRowKeys<Kinds.Document> keys(DocumentHandleCollection src)
            => keys(src.Array(), default(Kinds.Document));

        [Op]
        public static CliRowKeys<Kinds.ExportedType> keys(ExportedTypeHandleCollection src)
            => keys(src.Array(), default(Kinds.ExportedType));

        [Op]
        public static CliRowKeys<Kinds.Event> keys(EventDefinitionHandleCollection src)
            => keys(src.Array(), default(Kinds.Event));

        [Op]
        public static CliRowKeys<Field> keys(FieldDefinitionHandleCollection src)
            => keys(src.Array(), default(Kinds.Field));

        [Op]
        public static CliRowKeys<Kinds.Param> keys(ParameterHandleCollection src)
            => keys(src.Array(), default(Kinds.Param));

        [Op]
        public static CliRowKeys<GenericParam> keys(GenericParameterHandleCollection src)
            => keys(src.Array(), default(GenericParam));

        [Op]
        public static CliRowKeys<GenericParamConstraint> keys(GenericParameterConstraintHandleCollection src)
            => keys(src.Array(), default(GenericParamConstraint));

        [Op]
        public static CliRowKeys<MemberRef> keys(MemberReferenceHandleCollection src)
            => keys(src.Array(), default(MemberRef));

        [Op]
        public static CliRowKeys<Kinds.ManifestResource> keys(ManifestResourceHandleCollection src)
            => keys(src.Array(), default(Kinds.ManifestResource));

        [Op]
        public static CliRowKeys<MethodDef> keys(MethodDefinitionHandleCollection src)
            => keys(src.Array(), default(MethodDef));

        [Op]
        public static CliRowKeys<Property> keys(PropertyDefinitionHandleCollection src)
            => keys(src.Array(), default(Property));

        [Op]
        public static CliRowKeys<TypeDef> keys(TypeDefinitionHandleCollection src)
            => keys(src.Array(), default(TypeDef));

        [Op]
        public static CliRowKeys<TypeRef> keys(TypeReferenceHandleCollection src)
            => keys(src.Array(), default(TypeRef));

        [Op]
        public static CliRowKeys<Kinds.MethodDebugInformation> keys(MethodDebugInformationHandleCollection src)
            => keys(src.Array(), default(Kinds.MethodDebugInformation));

        [Op]
        public static CliRowKeys<Kinds.CustomDebugInformation> keys(CustomDebugInformationHandleCollection src)
            => keys(src.Array(), default(Kinds.CustomDebugInformation));

        // [Op]
        // public static CliRowKeys keys(DeclarativeSecurityAttributeHandleCollection src)
        //     => (src.Array().Select(handle => key(K.DeclSecurity, handle)), K.DeclSecurity);

        // [Op]
        // public static CliRowKeys keys(LocalVariableHandleCollection src)
        //     => (src.Map(handle => key(K.LocalVariable, handle)), K.LocalVariable);

        // [Op]
        // public static CliRowKeys keys(LocalConstantHandleCollection src)
        //     => (src.Map(handle => key(K.LocalConstant, handle)), K.LocalConstant);

        // [Op]
        // public static CliRowKeys keys(ImportScopeCollection src)
        //     => (src.Map(handle => key(K.ImportScope, handle)), K.ImportScope);

        [Op]
        public static CliRowKeys<Kinds.LocalScope> keys(LocalScopeHandleCollection src)
            => keys(src.Array(), default(Kinds.LocalScope));
    }
}