//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiMemberEntity
    {
        public MemoryAddress Address;

        public ApiMetadataUri MetaUri;

        public ApiHostUri Host;

        public ApiClass ApiKind;

        public CilMethod Cil;
    }
}