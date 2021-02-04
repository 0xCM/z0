//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    public struct ApiHostMemberEntities : IRecord<ApiHostMemberEntities>
    {
        public ApiHostUri Host;

        public TableSpan<ApiMemberEntity> Members;
    }
}