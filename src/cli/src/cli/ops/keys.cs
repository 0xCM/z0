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
    using static CliTableKinds;

    using K = CliTableKinds;

    partial struct Cli
    {
        [MethodImpl(Inline)]
        internal static CliRowKey<K> key<K,T>(T handle, K k = default)
            where K : unmanaged, ICliTableKind<K>
            where T : unmanaged
                => uint32(handle);

        internal static CliRowKeys<K> keys<K,T>(T[] handles, K k = default)
            where T : unmanaged
            where K : unmanaged, ICliTableKind<K>
        {
            var count = handles.Length;
            var src = @readonly(handles);
            var buffer = alloc<CliRowKey<K>>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = key<K,T>(skip(src,i));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static CliRowKey<MethodDef> key(MethodDefinitionHandle src)
            => key(src,default(MethodDef));

        [Op]
        public static CliRowKeys<File> keys(AssemblyFileHandleCollection src)
            => keys(src.Array(), default(File));

        [Op]
        public static CliRowKeys<AssemblyRef> keys(AssemblyReferenceHandleCollection src)
            => keys(src.Array(), default(AssemblyRef));

        [Op]
        public static CliRowKeys<K.CustomAttribute> keys(CustomAttributeHandleCollection src)
            => keys(src.Array(), default(K.CustomAttribute));

        [Op]
        public static CliRowKeys<K.Document> keys(DocumentHandleCollection src)
            => keys(src.Array(), default(K.Document));

        [Op]
        public static CliRowKeys<K.ExportedType> keys(ExportedTypeHandleCollection src)
            => keys(src.Array(), default(K.ExportedType));

        [Op]
        public static CliRowKeys<K.Event> keys(EventDefinitionHandleCollection src)
            => keys(src.Array(), default(K.Event));

        [Op]
        public static CliRowKeys<Field> keys(FieldDefinitionHandleCollection src)
            => keys(src.Array(), default(K.Field));

        [Op]
        public static CliRowKeys<K.Param> keys(ParameterHandleCollection src)
            => keys(src.Array(), default(K.Param));

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
        public static CliRowKeys<K.ManifestResource> keys(ManifestResourceHandleCollection src)
            => keys(src.Array(), default(K.ManifestResource));

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
        public static CliRowKeys<K.MethodDebugInformation> keys(MethodDebugInformationHandleCollection src)
            => keys(src.Array(), default(K.MethodDebugInformation));

        [Op]
        public static CliRowKeys<K.CustomDebugInformation> keys(CustomDebugInformationHandleCollection src)
            => keys(src.Array(), default(K.CustomDebugInformation));

        [Op]
        public static CliRowKeys<K.LocalScope> keys(LocalScopeHandleCollection src)
            => keys(src.Array(), default(K.LocalScope));
    }
}