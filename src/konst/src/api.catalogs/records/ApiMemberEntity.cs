//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    public struct ApiMemberEntity : IRecord<ApiMemberEntity>
    {
        public MemoryAddress Address;

        public ApiArtifactKey ArtifactUri;

        public ApiHostUri Host;

        public ApiClass ApiKind;

        public CilMethod Cil;
    }
}