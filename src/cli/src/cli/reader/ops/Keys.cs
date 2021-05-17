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
    using static core;

    using K = CliTableKinds;

    partial class CliReader
    {
        [MethodImpl(Inline), Op]
        public CliRowKey Key(MethodDefinitionHandle src)
            => key(src, default(MethodDef));

        [Op]
        public CliRowKeys Keys(AssemblyFileHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(File));

        [Op]
        public CliRowKeys Keys(AssemblyReferenceHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(AssemblyRef));

        [Op]
        public CliRowKeys Keys(CustomAttributeHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.CustomAttribute));

        [Op]
        public CliRowKeys Keys(DocumentHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.Document));

        [Op]
        public CliRowKeys Keys(ExportedTypeHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.ExportedType));

        [Op]
        public CliRowKeys Keys(EventDefinitionHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.Event));

        [Op]
        public CliRowKeys Keys(FieldDefinitionHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.Field));

        [Op]
        public CliRowKeys Keys(ParameterHandleCollection src)
        {
            var count = src.Count;
            var buffer = core.alloc<CliRowKey>(count);
            var i=0;
            ref var dst = ref first(buffer);
            foreach(var handle in src)
                seek(dst,i++) = Cli.key(handle);
            return buffer;
        }

        [Op]
        public ReadOnlySpan<CliRowKey> IntefaceImplKeys(TypeDefinition src)
            => src.GetInterfaceImplementations().Map(x => Cli.key(MD.GetInterfaceImplementation(x).Interface)).ToReadOnlySpan();

        [Op]
        public CliRowKeys Keys(GenericParameterHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(GenericParam));

        [Op]
        public CliRowKeys Keys(GenericParameterConstraintHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(GenericParamConstraint));

        [Op]
        public CliRowKeys Keys(MemberReferenceHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(MemberRef));

        [Op]
        public CliRowKeys Keys(ManifestResourceHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.ManifestResource));

        [Op]
        public CliRowKeys Keys(MethodDefinitionHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(MethodDef));

        [Op]
        public CliRowKeys Keys(PropertyDefinitionHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(Property));

        [Op]
        public CliRowKeys Keys(TypeDefinitionHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(TypeDef));

        [Op]
        public CliRowKeys Keys(TypeReferenceHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(TypeRef));

        [Op]
        public CliRowKeys Keys(MethodDebugInformationHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.MethodDebugInformation));

        [Op]
        public CliRowKeys Keys(CustomDebugInformationHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.CustomDebugInformation));

        [Op]
        public CliRowKeys Keys(LocalScopeHandleCollection src)
            => keys(src.ToReadOnlySpan(), default(K.LocalScope));
    }
}