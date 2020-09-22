//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    partial class PeTableReader
    {
        internal static TableIndex? index(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }

        internal static int HeapCount
            => MetadataTokens.HeapCount;

        internal static int TableCount
            => MetadataTokens.HeapCount;

        internal static int GetHeapOffset(UserStringHandle src)
            => MetadataTokens.GetHeapOffset(src);

        internal static int GetHeapOffset(StringHandle handle)
            => MetadataTokens.GetHeapOffset(handle);

        internal static int GetHeapOffset(in ReaderState state, Handle src)
            => MetadataTokens.GetHeapOffset(state.Reader, src);

        internal static UserStringHandle UserStringHandle(int offset)
            => MetadataTokens.UserStringHandle(offset);

        internal static int GetHeapOffset(Handle src)
            => MetadataTokens.GetHeapOffset(src);

        public static FieldDefinitionHandle FieldDefinitionHandle(uint row)
            => MetadataTokens.FieldDefinitionHandle((int)row);

        public static ConstantHandle ConstantHandle(uint row)
            => MetadataTokens.ConstantHandle((int)row);

        internal static StringHandle StringHandle(int offset)
            => MetadataTokens.StringHandle(offset);

        internal static BlobHandle BlobHandle(int offset)
            => MetadataTokens.BlobHandle(offset);

        internal static int GetHeapOffset(BlobHandle src)
            => MetadataTokens.GetHeapOffset(src);

        internal static int GetHeapOffset(GuidHandle src)
            => MetadataTokens.GetHeapOffset(src);

        public static uint row(EntityHandle handle)
            => (uint)MetadataTokens.GetRowNumber(handle);

        public static uint row(in ReaderState state, EntityHandle handle)
            => (uint)MetadataTokens.GetRowNumber(state.Reader,handle);

        public static EntityHandle EntityHandle(TableIndex tableIndex, uint row)
            => MetadataTokens.EntityHandle(tableIndex, (int)row);

        public static EntityHandle EntityHandle(ClrArtifactKey id)
            => MetadataTokens.EntityHandle((int)id);

        public static MethodDefinitionHandle MethodDefinitionHandle(uint row)
            => MetadataTokens.MethodDefinitionHandle((int)row);

        internal static int GetToken(EntityHandle handle)
            => MetadataTokens.GetToken(handle);

        public static TypeDefinitionHandle TypeDefinitionHandle(uint row)
            => MetadataTokens.TypeDefinitionHandle((int)row);

        public static TypeReferenceHandle TypeReferenceHandle(uint row)
            => MetadataTokens.TypeReferenceHandle((int)row);

        public static TypeSpecificationHandle TypeSpecificationHandle(uint row)
            => MetadataTokens.TypeSpecificationHandle((int)row);
    }
}