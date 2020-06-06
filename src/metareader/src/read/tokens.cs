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

    partial class MetadataRead
    {        
        internal static int HeapCount => MetadataTokens.HeapCount;
        
        internal static int TableCount => MetadataTokens.HeapCount;

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

        // internal static AssemblyFileHandle AssemblyFileHandle(int rowNumber) => MetadataTokens.
        // internal static AssemblyReferenceHandle AssemblyReferenceHandle(int rowNumber) => MetadataTokens.
        // internal static CustomAttributeHandle CustomAttributeHandle(int rowNumber) => MetadataTokens.
        // internal static CustomDebugInformationHandle CustomDebugInformationHandle(int rowNumber) => MetadataTokens.
        // internal static DeclarativeSecurityAttributeHandle DeclarativeSecurityAttributeHandle(int rowNumber) => MetadataTokens.
        // internal static DocumentHandle DocumentHandle(int rowNumber) => MetadataTokens.
        // internal static DocumentNameBlobHandle DocumentNameBlobHandle(int offset) => MetadataTokens.
        // internal static EventDefinitionHandle EventDefinitionHandle(int rowNumber) => MetadataTokens.
        // internal static ExportedTypeHandle ExportedTypeHandle(int rowNumber) => MetadataTokens.
        // internal static GenericParameterConstraintHandle GenericParameterConstraintHandle(int rowNumber) => MetadataTokens.
        // internal static GenericParameterHandle GenericParameterHandle(int rowNumber) => MetadataTokens.
        // internal static GuidHandle GuidHandle(int offset) => MetadataTokens.
        // internal static EntityHandle Handle(TableIndex tableIndex, int rowNumber) => MetadataTokens.
        // internal static ImportScopeHandle ImportScopeHandle(int rowNumber) => MetadataTokens.
        // internal static InterfaceImplementationHandle InterfaceImplementationHandle(int rowNumber) => MetadataTokens.
        // internal static LocalConstantHandle LocalConstantHandle(int rowNumber) => MetadataTokens.
        // internal static LocalScopeHandle LocalScopeHandle(int rowNumber) => MetadataTokens.
        // internal static LocalVariableHandle LocalVariableHandle(int rowNumber) => MetadataTokens.
        // internal static ManifestResourceHandle ManifestResourceHandle(int rowNumber) => MetadataTokens.
        // internal static MemberReferenceHandle MemberReferenceHandle(int rowNumber) => MetadataTokens.
        // internal static MethodDebugInformationHandle MethodDebugInformationHandle(int rowNumber) => MetadataTokens.
        // internal static MethodImplementationHandle MethodImplementationHandle(int rowNumber) => MetadataTokens.
        // internal static MethodSpecificationHandle MethodSpecificationHandle(int rowNumber) => MetadataTokens.
        // internal static ModuleReferenceHandle ModuleReferenceHandle(int rowNumber) => MetadataTokens.
        // internal static ParameterHandle ParameterHandle(int rowNumber) => MetadataTokens.
        // internal static PropertyDefinitionHandle PropertyDefinitionHandle(int rowNumber) => MetadataTokens.
        // internal static StandaloneSignatureHandle StandaloneSignatureHandle(int rowNumber) => MetadataTokens.
        // internal static bool TryGetHeapIndex(HandleKind type, out HeapIndex index) => MetadataTokens.
        // internal static bool TryGetTableIndex(HandleKind type, out TableIndex index) => MetadataTokens.
    }
}