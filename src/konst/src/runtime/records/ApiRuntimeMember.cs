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

        public ApiMetadataUri Uri;

        public GenericState Genericity;

        public MethodMetadata Metadata;

        public string Sig;

        public CilMethod Cil;
    }
}