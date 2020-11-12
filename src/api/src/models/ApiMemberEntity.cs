//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct ApiDataModel
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct ApiMemberEntity
        {
            public MemoryAddress Address;

            public ApiMetadataUri MetaUri;

            public ApiHostUri Host;

            public ApiClass ApiKind;

            public CilMethod Cil;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ApiHostMemberEntities
        {
            public ApiHostUri Host;

            public TableSpan<ApiMemberEntity> Members;
        }
    }
}