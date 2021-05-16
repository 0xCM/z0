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

        internal static CliRowKeys keys<K,T>(T[] handles, K k = default)
            where T : unmanaged
            where K : unmanaged, ICliTableKind<K>
        {
            var count = handles.Length;
            var src = @readonly(handles);
            var buffer = alloc<CliRowKey>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = key<K,T>(skip(src,i));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static CliRowKey<MethodDef> key(MethodDefinitionHandle src)
            => key(src,default(MethodDef));

        [Op]
        public static CliRowKeys keys(AssemblyFileHandleCollection src)
            => keys(src.Array(), default(File));

        [Op]
        public static CliRowKeys keys(AssemblyReferenceHandleCollection src)
            => keys(src.Array(), default(AssemblyRef));

        [Op]
        public static CliRowKeys keys(CustomAttributeHandleCollection src)
            => keys(src.Array(), default(K.CustomAttribute));

        [Op]
        public static CliRowKeys keys(DocumentHandleCollection src)
            => keys(src.Array(), default(K.Document));

        [Op]
        public static CliRowKeys keys(ExportedTypeHandleCollection src)
            => keys(src.Array(), default(K.ExportedType));

        [Op]
        public static CliRowKeys keys(EventDefinitionHandleCollection src)
            => keys(src.Array(), default(K.Event));

        [Op]
        public static CliRowKeys keys(FieldDefinitionHandleCollection src)
            => keys(src.Array(), default(K.Field));

        [Op]
        public static CliRowKeys keys(ParameterHandleCollection src)
            => keys(src.Array(), default(K.Param));

        [Op]
        public static CliRowKeys keys(GenericParameterHandleCollection src)
            => keys(src.Array(), default(GenericParam));

        [Op]
        public static CliRowKeys keys(GenericParameterConstraintHandleCollection src)
            => keys(src.Array(), default(GenericParamConstraint));

        [Op]
        public static CliRowKeys keys(MemberReferenceHandleCollection src)
            => keys(src.Array(), default(MemberRef));

        [Op]
        public static CliRowKeys keys(ManifestResourceHandleCollection src)
            => keys(src.Array(), default(K.ManifestResource));

        [Op]
        public static CliRowKeys keys(MethodDefinitionHandleCollection src)
            => keys(src.Array(), default(MethodDef));

        [Op]
        public static CliRowKeys keys(PropertyDefinitionHandleCollection src)
            => keys(src.Array(), default(Property));

        [Op]
        public static CliRowKeys keys(TypeDefinitionHandleCollection src)
            => keys(src.Array(), default(TypeDef));

        [Op]
        public static CliRowKeys keys(TypeReferenceHandleCollection src)
            => keys(src.Array(), default(TypeRef));

        [Op]
        public static CliRowKeys keys(MethodDebugInformationHandleCollection src)
            => keys(src.Array(), default(K.MethodDebugInformation));

        [Op]
        public static CliRowKeys keys(CustomDebugInformationHandleCollection src)
            => keys(src.Array(), default(K.CustomDebugInformation));

        [Op]
        public static CliRowKeys keys(LocalScopeHandleCollection src)
            => keys(src.Array(), default(K.LocalScope));
    }
}