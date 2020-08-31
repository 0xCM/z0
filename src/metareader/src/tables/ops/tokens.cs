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

    partial struct ReaderInternals
    {
        internal static TableIndex? index(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }

        public static HandleInfo? describe(in ReaderState state, Handle handle)
        {
            if(!handle.IsNil)
            {
                var table = index(handle);
                var token = state.Reader.GetToken(handle);
                if (table != null)
                    return new HandleInfo(token, table.Value);
            }

            return null;
        }

        internal static string token(in ReaderState state, Handle handle, bool displayTable = true)
        {
            if (handle.IsNil)
                return "null";

            var table = index(handle);
            var token = state.Reader.GetToken(handle);
            var tokenFmt = PaddedHex(token);
            if (displayTable && table != null)
                return $"{tokenFmt} | {table}";
            else
                return tokenFmt;
        }

        internal static int HeapCount
            => MetadataTokens.HeapCount;

        internal static int TableCount
            => MetadataTokens.HeapCount;

        internal static int GetHeapOffset(UserStringHandle handle)
            => MetadataTokens.GetHeapOffset(handle);

        internal static int GetHeapOffset(StringHandle handle)
            => MetadataTokens.GetHeapOffset(handle);

        internal static int GetHeapOffset(in ReaderState state, Handle handle)
            => MetadataTokens.GetHeapOffset(state.Reader, handle);

        internal static UserStringHandle UserStringHandle(int offset)
            => MetadataTokens.UserStringHandle(offset);

        internal static int GetHeapOffset(Handle handle)
            => MetadataTokens.GetHeapOffset(handle);

        internal static FieldDefinitionHandle FieldDefinitionHandle(int rowNumber)
            => MetadataTokens.FieldDefinitionHandle(rowNumber);

        internal static ConstantHandle ConstantHandle(int rowNumber)
            => MetadataTokens.ConstantHandle(rowNumber);

        internal static StringHandle StringHandle(int offset)
            => MetadataTokens.StringHandle(offset);

        internal static BlobHandle BlobHandle(int offset)
            => MetadataTokens.BlobHandle(offset);

        internal static int GetHeapOffset(BlobHandle handle)
            => MetadataTokens.GetHeapOffset(handle);
        internal static int GetHeapOffset(GuidHandle handle)
            => MetadataTokens.GetHeapOffset(handle);

        internal static int GetRowNumber(EntityHandle handle)
            => MetadataTokens.GetRowNumber(handle);

        internal static EntityHandle EntityHandle(TableIndex tableIndex, int rowNumber)
            => MetadataTokens.EntityHandle(tableIndex,rowNumber);

        internal static int GetRowNumber(in ReaderState state, EntityHandle handle)
            => MetadataTokens.GetRowNumber(state.Reader,handle);

        internal static int GetToken(in ReaderState state, Handle handle)
            => MetadataTokens.GetToken(state.Reader, handle);

        internal static int GetToken(in ReaderState state, EntityHandle handle)
            => MetadataTokens.GetToken(state.Reader, handle);

        internal static int GetToken(Handle handle)
            => MetadataTokens.GetToken(handle);

        internal static EntityHandle EntityHandle(int token)
            => MetadataTokens.EntityHandle(token);

        internal static MethodDefinitionHandle MethodDefinitionHandle(int rowNumber)
            => MetadataTokens.MethodDefinitionHandle(rowNumber);

        internal static int GetToken(EntityHandle handle)
            => MetadataTokens.GetToken(handle);

        internal static Handle Handle(int token)
            => MetadataTokens.Handle(token);

        internal static TypeDefinitionHandle TypeDefinitionHandle(int rowNumber)
            => MetadataTokens.TypeDefinitionHandle(rowNumber);

        internal static TypeReferenceHandle TypeReferenceHandle(int rowNumber)
            => MetadataTokens.TypeReferenceHandle(rowNumber);

        internal static TypeSpecificationHandle TypeSpecificationHandle(int rowNumber)
            => MetadataTokens.TypeSpecificationHandle(rowNumber);
    }
}