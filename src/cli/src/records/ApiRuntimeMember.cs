//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record]
    public struct ApiRuntimeMember : IRecord<ApiRuntimeMember>
    {
        public MemoryAddress Address;

        public ApiMetadataUri Uri;

        public GenericState Genericity;

        public MethodMetadata Metadata;

        public string Sig;

        public CilMethod Cil;
    }
}