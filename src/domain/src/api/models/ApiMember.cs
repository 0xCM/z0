//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ApiData
    {
        public struct ApiMember
        {
            public MemoryAddress Address;

            public ApiMetadataUri MetaUri;

            public ApiHostUri Host;

            public ApiOpId ApiKind;

            public CilMethod Cil;
        }

        public struct ApiHostMembers
        {
            public ApiHostUri Host;

            public TableSpan<ApiMember> Members;
        }
    }
}