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

    using static Root;
    using static Cli;
    using static CliTableKinds;

    using K = CliTableKinds;

    partial class CliReader
    {
        [MethodImpl(Inline), Op]
        public CliRowKey Key(MethodDefinitionHandle src)
            => key(src, default(MethodDef));

        [Op]
        public CliRowKeys Keys(AssemblyFileHandleCollection src)
            => keys(src.Array(), default(File));

        [Op]
        public CliRowKeys Keys(AssemblyReferenceHandleCollection src)
            => keys(src.Array(), default(AssemblyRef));

        [Op]
        public CliRowKeys Keys(CustomAttributeHandleCollection src)
            => keys(src.Array(), default(K.CustomAttribute));

        [Op]
        public CliRowKeys Keys(DocumentHandleCollection src)
            => keys(src.Array(), default(K.Document));

        [Op]
        public CliRowKeys Keys(ExportedTypeHandleCollection src)
            => keys(src.Array(), default(K.ExportedType));

        [Op]
        public CliRowKeys Keys(EventDefinitionHandleCollection src)
            => keys(src.Array(), default(K.Event));

        [Op]
        public CliRowKeys Keys(FieldDefinitionHandleCollection src)
            => keys(src.Array(), default(K.Field));

        [Op]
        public CliRowKeys Keys(ParameterHandleCollection src)
            => keys(src.Array(), default(K.Param));

        [Op]
        public CliRowKeys Keys(GenericParameterHandleCollection src)
            => keys(src.Array(), default(GenericParam));

        [Op]
        public CliRowKeys Keys(GenericParameterConstraintHandleCollection src)
            => keys(src.Array(), default(GenericParamConstraint));

        [Op]
        public CliRowKeys Keys(MemberReferenceHandleCollection src)
            => keys(src.Array(), default(MemberRef));

        [Op]
        public CliRowKeys Keys(ManifestResourceHandleCollection src)
            => keys(src.Array(), default(K.ManifestResource));

        [Op]
        public CliRowKeys Keys(MethodDefinitionHandleCollection src)
            => keys(src.Array(), default(MethodDef));

        [Op]
        public CliRowKeys Keys(PropertyDefinitionHandleCollection src)
            => keys(src.Array(), default(Property));

        [Op]
        public CliRowKeys Keys(TypeDefinitionHandleCollection src)
            => keys(src.Array(), default(TypeDef));

        [Op]
        public CliRowKeys Keys(TypeReferenceHandleCollection src)
            => keys(src.Array(), default(TypeRef));

        [Op]
        public CliRowKeys Keys(MethodDebugInformationHandleCollection src)
            => keys(src.Array(), default(K.MethodDebugInformation));

        [Op]
        public CliRowKeys Keys(CustomDebugInformationHandleCollection src)
            => keys(src.Array(), default(K.CustomDebugInformation));

        [Op]
        public CliRowKeys Keys(LocalScopeHandleCollection src)
            => keys(src.Array(), default(K.LocalScope));
    }
}