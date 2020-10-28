//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/dotnet/runtime/src/libraries/System.Reflection.MetadataLoadContext
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace System.Reflection.Metadata
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection.Metadata.Ecma335;
    using System.Collections.Immutable;

    using Z0;

    using static Z0.Part;

    [ApiHost(ApiNames.XSrm)]
    public static class XSrm
    {
        [MethodImpl(Inline), Op]
        public static ManifestResource GetManifestResource(this ManifestResourceHandle handle, MetadataReader reader)
            => reader.GetManifestResource(handle);

        [MethodImpl(Inline), Op]
        public static AssemblyFile GetAssemblyFile(this AssemblyFileHandle handle, MetadataReader reader)
            => reader.GetAssemblyFile(handle);

        [MethodImpl(Inline), Op]
        public static AssemblyReference GetAssemblyReference(this AssemblyReferenceHandle handle, MetadataReader reader)
            => reader.GetAssemblyReference(handle);

        [MethodImpl(Inline), Op]
        public static byte[] GetBlobBytes(this BlobHandle handle, MetadataReader reader)
            => reader.GetBlobBytes(handle);

        [MethodImpl(Inline), Op]
        public static ImmutableArray<byte> GetBlobContent(this BlobHandle handle, MetadataReader reader)
            => reader.GetBlobContent(handle);

        [MethodImpl(Inline), Op]
        public static BlobReader GetBlobReader(this BlobHandle handle, MetadataReader reader)
            => reader.GetBlobReader(handle);

        [MethodImpl(Inline), Op]
        public static BlobReader GetBlobReader(this StringHandle handle, MetadataReader reader)
            => reader.GetBlobReader(handle);

        [MethodImpl(Inline), Op]
        public static Constant GetConstant(this ConstantHandle handle, MetadataReader reader)
            => reader.GetConstant(handle);

        [MethodImpl(Inline), Op]
        public static CustomAttribute GetCustomAttribute(this CustomAttributeHandle handle, MetadataReader reader)
            => reader.GetCustomAttribute(handle);

        [MethodImpl(Inline), Op]
        public static CustomAttributeHandleCollection GetCustomAttributes(this EntityHandle handle, MetadataReader reader)
            => reader.GetCustomAttributes(handle);

        [MethodImpl(Inline), Op]
        public static CustomDebugInformation GetCustomDebugInformation(this CustomDebugInformationHandle handle, MetadataReader reader)
            => reader.GetCustomDebugInformation(handle);

        [MethodImpl(Inline), Op]
        public static CustomDebugInformationHandleCollection GetCustomDebugInformation(this EntityHandle handle, MetadataReader reader)
            => reader.GetCustomDebugInformation(handle);

        [MethodImpl(Inline), Op]
        public static DeclarativeSecurityAttribute GetDeclarativeSecurityAttribute(this DeclarativeSecurityAttributeHandle handle, MetadataReader reader)
            => reader.GetDeclarativeSecurityAttribute(handle);

        [MethodImpl(Inline), Op]
        public static Document GetDocument(this DocumentHandle handle, MetadataReader reader)
            => reader.GetDocument(handle);

        [MethodImpl(Inline), Op]
        public static EventDefinition GetEventDefinition(this EventDefinitionHandle handle, MetadataReader reader)
            => reader.GetEventDefinition(handle);

        [MethodImpl(Inline), Op]
        public static ExportedType GetExportedType(this ExportedTypeHandle handle, MetadataReader reader)
            => reader.GetExportedType(handle);

        [MethodImpl(Inline), Op]
        public static FieldDefinition GetFieldDefinition(this FieldDefinitionHandle handle, MetadataReader reader)
            => reader.GetFieldDefinition(handle);

        [MethodImpl(Inline), Op]
        public static GenericParameter GetGenericParameter(this GenericParameterHandle handle, MetadataReader reader)
            => reader.GetGenericParameter(handle);

        [MethodImpl(Inline), Op]
        public static GenericParameterConstraint GetGenericParameterConstraint(this GenericParameterConstraintHandle handle, MetadataReader reader)
            => reader.GetGenericParameterConstraint(handle);

        [MethodImpl(Inline), Op]
        public static Guid GetGuid(this GuidHandle handle, MetadataReader reader)
            => reader.GetGuid(handle);

        [MethodImpl(Inline), Op]
        public static ImportScope GetImportScope(this ImportScopeHandle handle, MetadataReader reader)
            => reader.GetImportScope(handle);

        [MethodImpl(Inline), Op]
        public static InterfaceImplementation GetInterfaceImplementation(this InterfaceImplementationHandle handle, MetadataReader reader)
            => reader.GetInterfaceImplementation(handle);

        [MethodImpl(Inline), Op]
        public static LocalConstant GetLocalConstant(this LocalConstantHandle handle, MetadataReader reader)
            => reader.GetLocalConstant(handle);

        [MethodImpl(Inline), Op]
        public static LocalScope GetLocalScope(this LocalScopeHandle handle, MetadataReader reader)
            => reader.GetLocalScope(handle);

        [MethodImpl(Inline), Op]
        public static LocalScopeHandleCollection GetLocalScopes(this MethodDefinitionHandle handle, MetadataReader reader)
            => reader.GetLocalScopes(handle);

        [MethodImpl(Inline), Op]
        public static LocalScopeHandleCollection GetLocalScopes(this MethodDebugInformationHandle handle, MetadataReader reader)
            => reader.GetLocalScopes(handle);

        [MethodImpl(Inline), Op]
        public static LocalVariable GetLocalVariable(this LocalVariableHandle handle, MetadataReader reader)
            => reader.GetLocalVariable(handle);

        [MethodImpl(Inline), Op]
        public static MemberReference GetMemberReference(this MemberReferenceHandle handle, MetadataReader reader)
            => reader.GetMemberReference(handle);

        [MethodImpl(Inline), Op]
        public static MethodDebugInformation GetMethodDebugInformation(this MethodDebugInformationHandle handle, MetadataReader reader)
            => reader.GetMethodDebugInformation(handle);

        [MethodImpl(Inline), Op]
        public static MethodDebugInformation GetMethodDebugInformation(this MethodDefinitionHandle handle, MetadataReader reader)
            => reader.GetMethodDebugInformation(handle);

        [MethodImpl(Inline), Op]
        public static MethodDefinition GetMethodDefinition(this MethodDefinitionHandle handle, MetadataReader reader)
            => reader.GetMethodDefinition(handle);

        [MethodImpl(Inline), Op]
        public static MethodImplementation GetMethodImplementation(this MethodImplementationHandle handle, MetadataReader reader)
            => reader.GetMethodImplementation(handle);

        [MethodImpl(Inline), Op]
        public static MethodSpecification GetMethodSpecification(this MethodSpecificationHandle handle, MetadataReader reader)
            => reader.GetMethodSpecification(handle);

        [MethodImpl(Inline), Op]
        public static ModuleReference GetModuleReference(this ModuleReferenceHandle handle, MetadataReader reader)
            => reader.GetModuleReference(handle);

        [MethodImpl(Inline), Op]
        public static NamespaceDefinition GetNamespaceDefinition(this NamespaceDefinitionHandle handle, MetadataReader reader)
            => reader.GetNamespaceDefinition(handle);

        [MethodImpl(Inline), Op]
        public static Parameter GetParameter(this ParameterHandle handle, MetadataReader reader)
            => reader.GetParameter(handle);

        [MethodImpl(Inline), Op]
        public static PropertyDefinition GetPropertyDefinition(this PropertyDefinitionHandle handle, MetadataReader reader)
            => reader.GetPropertyDefinition(handle);

        [MethodImpl(Inline), Op]
        public static StandaloneSignature GetStandaloneSignature(this StandaloneSignatureHandle handle, MetadataReader reader)
            => reader.GetStandaloneSignature(handle);

        [MethodImpl(Inline), Op]
        public static string GetString(this StringHandle handle, MetadataReader reader)
            => reader.GetString(handle);

        [MethodImpl(Inline), Op]
        public static string GetString(this NamespaceDefinitionHandle handle, MetadataReader reader)
            => reader.GetString(handle);

        [MethodImpl(Inline), Op]
        public static string GetString(this DocumentNameBlobHandle handle, MetadataReader reader)
            => reader.GetString(handle);

        [MethodImpl(Inline), Op]
        public static TypeDefinition GetTypeDefinition(this TypeDefinitionHandle handle, MetadataReader reader)
            => reader.GetTypeDefinition(handle);

        [MethodImpl(Inline), Op]
        public static TypeReference GetTypeReference(this TypeReferenceHandle handle, MetadataReader reader)
            => reader.GetTypeReference(handle);

        [MethodImpl(Inline), Op]
        public static TypeSpecification GetTypeSpecification(this TypeSpecificationHandle handle, MetadataReader reader)
            => reader.GetTypeSpecification(handle);

        [MethodImpl(Inline), Op]
        public static string GetUserString(this UserStringHandle handle, MetadataReader reader)
            => reader.GetUserString(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this Handle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this EntityHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this TypeDefinitionHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this TypeReferenceHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this TypeSpecificationHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this GenericParameterHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this GenericParameterConstraintHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this FieldDefinitionHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this EventDefinitionHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this MethodDefinitionHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this PropertyDefinitionHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this ParameterHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this StandaloneSignatureHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static int GetToken(this AssemblyFileHandle handle)
            => MetadataTokens.GetToken(handle);

        [MethodImpl(Inline), Op]
        public static string? GetStringOrNull(this StringHandle handle, MetadataReader reader)
            => handle.IsNil ? null : reader.GetString(handle);

        [MethodImpl(Inline), Op]
        public static bool Equals(this StringHandle handle, string value, MetadataReader reader)
            => reader.StringComparer.Equals(handle, value, ignoreCase: false);

        [MethodImpl(Inline), Op]
        public static unsafe bool Equals(this StringHandle handle, ReadOnlySpan<byte> utf8, MetadataReader reader)
        {
            BlobReader br = handle.GetBlobReader(reader);
            ReadOnlySpan<byte> actual = new ReadOnlySpan<byte>(br.CurrentPointer, br.Length);
            return utf8.SequenceEqual(actual);
        }

        [MethodImpl(Inline), Op]
        public static Handle ToHandle(this int token)
            => MetadataTokens.Handle(token);

        [MethodImpl(Inline), Op]
        public static TypeDefinitionHandle ToTypeDefinitionHandle(this int token)
            => MetadataTokens.TypeDefinitionHandle(token);

        [MethodImpl(Inline), Op]
        public static TypeReferenceHandle ToTypeReferenceHandle(this int token)
            => MetadataTokens.TypeReferenceHandle(token);

        [MethodImpl(Inline), Op]
        public static TypeSpecificationHandle ToTypeSpecificationHandle(this int token)
            => MetadataTokens.TypeSpecificationHandle(token);
    }
}