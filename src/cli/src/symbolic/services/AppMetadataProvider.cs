//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Reflection.PortableExecutable;
    using Microsoft.DiaSymReader;
    using System.Runtime.InteropServices;

    partial struct AppSymbolics
    {
        public sealed class AppMetadataProvider : ISymReaderMetadataProvider, IDisposable
        {
            readonly PEReader _peReader;

            readonly MetadataReader MetadataReader;

            public AppMetadataProvider(SymbolSource source)
            {
                _peReader = new PEReader(source.PeStream);
                MetadataReader = _peReader.GetMetadataReader();
            }

            public void Dispose()
            {
                _peReader.Dispose();
            }

            public unsafe bool TryGetStandaloneSignature(int standaloneSignatureToken, out byte* signature, out int length)
            {
                var sigHandle = (StandaloneSignatureHandle)MetadataTokens.Handle(standaloneSignatureToken);
                if (sigHandle.IsNil)
                {
                    signature = null;
                    length = 0;
                    return false;
                }

                var sig = MetadataReader.GetStandaloneSignature(sigHandle);
                var blobReader = MetadataReader.GetBlobReader(sig.Signature);

                signature = blobReader.StartPointer;
                length = blobReader.Length;
                return true;
            }

            public bool TryGetTypeDefinitionInfo(int typeDefinitionToken, out string namespaceName, out string typeName, out TypeAttributes attributes)
            {
                var handle = (TypeDefinitionHandle)MetadataTokens.Handle(typeDefinitionToken);
                if (handle.IsNil)
                {
                    namespaceName = null;
                    typeName = null;
                    attributes = 0;
                    return false;
                }

                var typeDefinition = MetadataReader.GetTypeDefinition(handle);
                namespaceName = MetadataReader.GetString(typeDefinition.Namespace);
                typeName = MetadataReader.GetString(typeDefinition.Name);
                attributes = typeDefinition.Attributes;
                return true;
            }

            public bool TryGetTypeReferenceInfo(int typeReferenceToken, out string namespaceName, out string typeName)
            {
                var handle = (TypeReferenceHandle)MetadataTokens.Handle(typeReferenceToken);
                if (handle.IsNil)
                {
                    namespaceName = null;
                    typeName = null;
                    return false;
                }

                var typeReference = MetadataReader.GetTypeReference(handle);
                namespaceName = MetadataReader.GetString(typeReference.Namespace);
                typeName = MetadataReader.GetString(typeReference.Name);
                return true;
            }

            public unsafe int GetSigFromToken(int tkSignature, out byte* ppvSig, out int pcbSig)
            {
                var signatureHandle = (StandaloneSignatureHandle)MetadataTokens.Handle(tkSignature);
                var bytes = MetadataReader.GetBlobBytes(MetadataReader.GetStandaloneSignature(signatureHandle).Signature);

                var pinned = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                ppvSig = (byte*)pinned.AddrOfPinnedObject();
                pcbSig = bytes.Length;
                return 0;
            }
        }
    }
}