//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ApiRuntimeSummary : IRecord<ApiRuntimeSummary>
    {
        public const string TableId = "api.summary";

        public MemoryAddress Address;

        public ApiArtifactUri Uri;

        public GenericState Genericity;

        public string Sig;

        public MethodMetadata Metadata;
    }
}