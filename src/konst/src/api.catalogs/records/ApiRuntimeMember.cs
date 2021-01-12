//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ApiRuntimeMember : IRecord<ApiRuntimeMember>
    {
        public const string TableId ="api.member";

        public MemoryAddress Address;

        public ApiArtifactUri ArtifactUri;

        public GenericState Genericity;

        public ClrMethodMetadata Metadata;

        public string Sig;

        public CilMethod Cil;
    }
}