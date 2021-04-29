//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection.Metadata;

    using static Part;
    using static memory;
    using static Images;

    partial class XImg
    {
        public static RowKeys RowKeys(this AssemblyFileHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this CustomAttributeHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this CustomDebugInformationHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this DeclarativeSecurityAttributeHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this DocumentHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this ExportedTypeHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this EventDefinitionHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this FieldDefinitionHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this ImportScopeCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this LocalScopeHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this LocalVariableHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this LocalConstantHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this MemberReferenceHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this ManifestResourceHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this MethodDefinitionHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this PropertyDefinitionHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this MethodDebugInformationHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this TypeDefinitionHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));

        public static RowKeys RowKeys(this TypeReferenceHandleCollection src)
            => src.Map(x => (RowKey)uint32(x));
    }
}